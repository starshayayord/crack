using System.Collections.Generic;

namespace Yord.Crack.Begin.Chapter7
{
    // Структура данных для онлайн библиотеки:
    // Создание и веденис списка подписчиков
    // Поиск книг в базе
    // Чтение
    // В каждый момент времени только один пользователь мб активен
    // Пользователь может читать только одну книгу
    public class Task5
    {
        public class OnlineReaderSystem
        {
            private Library _library;
            private UserManager _userManager;
            private Display _display;
            public Book ActiveBook { get; private set; }
            public User ActiveUser { get; private set; }

            public Library Library => _library;
            public UserManager UserManager => _userManager;
            public Display Display => _display;


            public OnlineReaderSystem()
            {
                _userManager = new UserManager();
                _library = new Library();
                _display = new Display();
            }

            public void SetActiveBook(Book book)
            {
                ActiveBook = book;
            }

            public void SetActiveUser(User user)
            {
                ActiveUser = user;
            }
        }

        public class Library
        {
            private Dictionary<int, Book> _books;

            public Book AddBook(int id, string details)
            {
                if (_books.ContainsKey(id)) return null;
                var book = new Book(id, details);
                _books.Add(id, book);
                return book;
            }

            public bool RemoveBook(Book book)
            {
                return RemoveBook(book.Id);
            }

            public bool RemoveBook(int id)
            {
                return _books.Remove(id);
            }

            public Book Find(int id)
            {
                return _books.GetValueOrDefault(id);
            }
        }

        public class UserManager
        {
            private Dictionary<int, User> _users;

            public User AddUser(int id, string details, int accountType)
            {
                if (_users.ContainsKey(id)) return null;
                var user = new User(id, details, accountType);
                _users.Add(id, user);
                return user;
            }

            public User Find(int id)
            {
                return _users.GetValueOrDefault(id);
            }

            public bool Remove(User user)
            {
                return Remove(user.Id);
            }

            public bool Remove(int id)
            {
                return _users.Remove(id);
            }
        }

        public class Display
        {
            private Book _activeBook;
            private User _activeUser;
            private int _pageNumber;

            public void DisplayUser(User user)
            {
                _activeUser = user;
                RefreshUsername();
            }

            public void DisplayBook(Book book)
            {
                _pageNumber = 0;
                _activeBook = book;
                RefreshTitleAndDetails();
                RefreshPage();
            }

            public void TurnPageForward()
            {
                _pageNumber++;
                RefreshPage();
            }

            public void TurnPageBackward()
            {
                if (_pageNumber != 0)
                {
                    _pageNumber--;
                    RefreshPage();
                }
            }

            private void RefreshPage()
            {
            }

            private void RefreshTitleAndDetails()
            {
            }

            private void RefreshUsername()
            {
            }
        }

        public class Book
        {
            private int _id;
            private string _details;
            
            public int Id => _id;
            public string Details => _details;

            public Book(int id, string details)
            {
                _id = id;
                _details = details;
            }
        }

        public class User
        {
            private int _id;
            private string _details;
            private int _accountType;
            
            public int Id => _id;
            public string Details => _details;
            public int AccountType => _accountType;

            public User(in int id, string details, in int accountType)
            {
                _id = id;
                _details = details;
                _accountType = accountType;
            }

            public void SetDetails(string details)
            {
                _details = details;
            }
        }
    }
}
