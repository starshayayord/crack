using System;
using System.Collections.Generic;

namespace Yord.Crack.Begin.Chapter7
{
    // Чат сервер:
    // вход/выход из чата, добавление запроса (отправка, прием, отклонение), обновление информации о статусе
    // создание приватных групп и чатов, добавление новых сообщений в присатные группы и чаты
    public class Task7
    {
        // Система будет состоять из БД, клиентов и серверов.
        // Для передачи данных используем JSON

        public class UserManager //пользователи, беседы, сообщения о статусах
            //(центральный класс для основных действий пользователя)
        {
            private static UserManager _instance;
            private Dictionary<int, User> _userById; // идентификатор - пользователь
            private Dictionary<string, User> _userByAccountName; //  логин - пользователь
            private Dictionary<int, User> _onlineUsers; // идентификатор - подключенный пользователь

            public static UserManager GetInstance()
            {
                return _instance ??= new UserManager();
            }

            public void AddUser(User fromUser, string toAccountName)
            {
                var toUser = _userByAccountName.GetValueOrDefault(toAccountName);
                if (toUser != null)
                {
                    // возможно, не самый лучший подход
                    var addRequest = new AddRequest(fromUser, toUser);
                    fromUser.SendAddRequest(addRequest);
                    toUser.ReceiveAddRequest(addRequest);
                }
            }

            // согласие на запрос о добавлении в список контактов
            public void ApproveAddRequest(AddRequest request)
            {
                request.SetStatus(RequestStatus.Accepted);
                request.FromUser.AddContact(request.ToUser);
                request.ToUser.AddContact(request.FromUser);
            }

            // отказ на запрос о добавлении в список контактов
            public void RejectAddRequest(AddRequest request)
            {
                request.SetStatus(RequestStatus.Rejected);
                request.FromUser.RemoveAddRequest(request);
                request.ToUser.RemoveAddRequest(request);
            }

            public void UserSignedOn(string accountName)
            {
                var user = _userByAccountName.GetValueOrDefault(accountName);
                if (user != null)
                {
                    user.SetStatus(new UserStatus(UserStatusType.Available));
                    _onlineUsers.TryAdd(user.Id, user);
                }
            }

            //  пользователь явно сообщает о завершении работы с клиентом
            // чтобы информация была актуальной в иных случаях - необходимо совершать периодический опрос клиента
            public void UserSignedOff(string accountName)
            {
                var user = _userByAccountName.GetValueOrDefault(accountName);
                if (user != null)
                {
                    user.SetStatus(new UserStatus(UserStatusType.Offline));
                    _onlineUsers.Remove(user.Id);
                }
            }
        }

        public class User
        {
            private int _id;
            private UserStatus _status;
            private string _accountName;
            private string _fullName;

            // идентификатор другого участника - приватный чат
            private Dictionary<int, PrivateChat> _privateChats;

            // групповой чат
            private List<GroupChat> _groupChats;

            // идентификатор другого участника - запросы на добавление в список контактов (полученные)
            private Dictionary<int, AddRequest> _receivedAddRequests;

            // идентификатор другого участника - запросы на добавление в список контактов (отправленные)
            private Dictionary<int, AddRequest> _sentAddRequests;

            private Dictionary<int, User> _contacts;

            public User(int id, string accountName, string fullName)
            {
                _id = id;
                _accountName = accountName;
                _fullName = fullName;
            }

            public UserStatus UserStatus => _status;
            public int Id => _id;
            public string AccountName => _accountName;
            public string FullName => _fullName;

            public bool SendMessageToUser(User toUser, string content)
            {
                var chat = _privateChats.GetValueOrDefault(toUser.Id);
                if (chat == null)
                {
                    chat = new PrivateChat(this, toUser);
                    _privateChats.Add(toUser.Id, chat);
                }
                var message = new Message(content);
                return chat.AddMessage(message);
            }

            public bool SendMessageToGroupChat(int groupId, string content)
            {
                var chat = _groupChats[groupId];
                if (chat == null)
                {
                    return false;
                }
                var message = new Message(content);
                return chat.AddMessage(message);

            }

            public void SetStatus(UserStatus status)
            {
                _status = status;
            }


            public bool AddContact(User user)
            {
                if (_contacts.ContainsKey(user.Id))
                {
                    return false;
                }
                _contacts.Add(user.Id, user);
                return true;
            }

            // Оповещает пользователя, что кто-то отправил запрос на добавление в список контактов
            public void ReceiveAddRequest(AddRequest request)
            {
                if (!_receivedAddRequests.ContainsKey(request.FromUser.Id))
                {
                    _receivedAddRequests.Add(request.FromUser.Id, request);
                }
            }

            public void SendAddRequest(AddRequest request)
            {
                if (!_sentAddRequests.ContainsKey(request.ToUser.Id))
                {
                    _sentAddRequests.Add(request.ToUser.Id, request);
                }
            }

            public void RemoveAddRequest(AddRequest request)
            {
                if (request.ToUser == this)
                {
                    _receivedAddRequests.Remove(request.FromUser.Id);
                }
                else
                {
                    _sentAddRequests.Remove(request.ToUser.Id);
                }
            }

            public void RequestAddUser(string accountName)
            {
                UserManager.GetInstance().AddUser(this, accountName);
            }

            public void AddConversation(PrivateChat conversation)
            {
                var anotherUser = conversation.GetAnotherParticipant(this);
                _privateChats.Add(anotherUser.Id, conversation);
            }

            public void AddConversation(GroupChat conversation)
            {
                _groupChats.Add(conversation);
            }
        }

        public abstract class Conversation
        {
            protected List<User> Participants;
            protected int id;
            protected List<Message> _messages;
            public List<Message> Messages => _messages;

            public int Id => id;

            public bool AddMessage(Message message)
            {
                _messages.Add(message);
                return true;
            }
        }

        public class PrivateChat : Conversation
        {
            public PrivateChat(User user1, User user2)
            {
                Participants.Add(user1);
                Participants.Add(user2);
            }

            public User GetAnotherParticipant(User primary)
            {
                return Participants[0] == primary ? Participants[1] : Participants[0];
            }
        }

        public class GroupChat : Conversation
        {
            public void RemoveParticipant(User user)
            {
                Participants.Remove(user);
            }

            public void AddParticipant(User user)
            {
                Participants.Add(user);
            }
        }

        public class Message
        {
            private string _content;
            private DateTime _date;

            public string Content => _content;

            public DateTime Date => _date;

            public Message(string content)
            {
                _content = content;
                _date = DateTime.Now;
            }
        }

        public class AddRequest
        {
            private User _fromUser;
            private User _toUser;
            private DateTime _date;
            private RequestStatus _status;

            public User FromUser => _fromUser;

            public User ToUser => _toUser;

            public DateTime Date => _date;

            public RequestStatus Status => _status;

            public AddRequest(User from, User to)
            {
                _fromUser = from;
                _toUser = to;
                _date = DateTime.Now;
                _status = RequestStatus.Unread;
            }

            public void SetStatus(RequestStatus status)
            {
                _status = status;
            }
        }

        public class UserStatus
        {
            private string _message;
            private UserStatusType _statusType;

            public string Message => _message;

            public UserStatusType StatusType => _statusType;

            public UserStatus(UserStatusType statusType, string message = null)
            {
                _statusType = statusType;
                _message = message;
            }
        }

        public enum UserStatusType
        {
            Offline,
            Away,
            Idle,
            Available,
            Busy
        }

        public enum RequestStatus
        {
            Unread,
            Read,
            Accepted,
            Rejected
        }
    }
}
