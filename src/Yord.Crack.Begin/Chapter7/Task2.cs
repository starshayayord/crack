using System.Collections.Generic;

namespace Yord.Crack.Begin.Chapter7
{
    // Спроектировать коллцентр с 3 уровнями обработки: оператор, менеджер директор.
    // Звонок адресуется свободному оператору. Если он не может обработать, то автоматически отправляем менеджеру.
    // Если мненеджер занят - директору.
    // Реализовать метод DispatchCall(), перенаправляющий звонок первому свободному сотруднику
    public class Task2
    {
        // Специфические функции сотрудников реализуем в соотв. классах, общие - в одном, который будем расширять.
        // CallHandler - класс для перенаправления вызовов.
        public class CallHandler
        {
            // 3 уровня работников
            private const int Levels = 3;

            private const int RespondentsCount = 10; // 10 операторов
            private const int ManagersCount = 4; // 4 менеджера
            private const int DirectorsCount = 2; // 2 директора

            private List<List<Employee>> _employeeLevels; // [0] - операторы, [1]-менеджеры, [2] - директоры
            private List<List<Call>> _callsQueue; // очередь для каждого вызова

            public CallHandler()
            {
                _employeeLevels =new List<List<Employee>>(Levels);
                _callsQueue = new List<List<Call>>(Levels);
                var respondents = new List<Employee>(RespondentsCount);
                for (var i = 0; i < RespondentsCount; i++)
                {
                    respondents.Add(new Responder(this));
                }
                _employeeLevels.Add(respondents);
                
                var managers = new List<Employee>(ManagersCount);
                for (var i = 0; i < ManagersCount; i++)
                {
                    managers.Add(new Manager(this));
                }
                _employeeLevels.Add(managers);
                
                var directors = new List<Employee>(DirectorsCount);
                for (var i = 0; i < DirectorsCount; i++)
                {
                    directors.Add(new Director(this));
                }
                _employeeLevels.Add(directors);
            }
            // получение первого доступного работника для обработк звонка
            public Employee GetHandlerForCall(Call call)
            {
                for (var l = (int)call.Rank; l < Levels - 1; l++)
                {
                    foreach (var e in _employeeLevels[l])
                    {
                        if (e.IsFree)
                        {
                            return e;
                        }
                    }
                }

                return null;
            }

            // Перенаправить звонок первому доступному работнику или положить в очередь при отсутствии.
            public void DispatchCall(Caller caller)
            {
                var call = new Call(caller);
                DispatchCall(call);
            }

            public void DispatchCall(Call call)
            {
                var employee = GetHandlerForCall(call);
                if (employee != null)
                {
                    employee.ReceiveCall(call);
                    call.SetHandler(employee);
                }
                else
                {
                    call.Reply("Please wait for free employee to reply.");
                    _callsQueue[(int)call.Rank].Add(call);
                }
            }

            // Работник освободился. Если ему был назначен звонок, то вернуть  true, иначе false
            public bool AssignCall(Employee employee)
            {
                for (var r = (int) employee.GetRank; r >= 0; r--)
                {
                    var queueForRank = _callsQueue[r];
                    if (_callsQueue.Count > 0)
                    {
                        var call = queueForRank[0];
                        queueForRank.RemoveAt(0);
                        employee.ReceiveCall(call);
                        return true;
                    }
                }

                return false;
            }
        }

        public abstract class Employee
        {
            private Call _currentCall;
            protected Rank Rank { get; set; }
            private CallHandler _callHandler;

            public Employee(CallHandler callHandler)
            {
                _callHandler = callHandler;
            }

            // начало обработки
            public void ReceiveCall(Call call)
            {
                _currentCall = call;
            }

            // проблема решена
            public void CallCompleted()
            {
                if (_currentCall != null)
                {
                    _currentCall.Disconnect();
                    _currentCall = null;
                }

                AssignNewCall();
            }

            // проблема осталась, передаем звонок выше, назначаем нового работника
            public void EscalateAndReassign()
            {
                if (_currentCall != null)
                {
                    _currentCall.IncrementRank();
                    _callHandler.DispatchCall(_currentCall);
                    _currentCall = null;
                }
                AssignNewCall();
            }

            // Назначить вызов работнику, если он свободен
            public bool AssignNewCall()
            {
                if (!IsFree) return false;
                return _callHandler.AssignCall(this);
            }

            public bool IsFree => _currentCall == null;

            public Rank GetRank => Rank;
        }

        public class Director : Employee
        {
            public Director(CallHandler callHandler) : base(callHandler)
            {
                Rank = Rank.Director;
            }
        }

        public class Manager : Employee
        {
            public Manager(CallHandler callHandler) : base(callHandler) 
            {
                Rank = Rank.Manager;
            }
        }

        public class Responder : Employee
        {
            public Responder(CallHandler callHandler) : base(callHandler)
            {
                Rank = Rank.Responder;
            }
        }

        // Звонок от абонента
        public class Call
        {
            public Call(Caller caller)
            {
                Caller = caller;
                Rank = Rank.Responder;
            }

            // минимальный ранг работника, который может обработать звонок
            public Rank Rank { get; private set; }

            // работник, обрабатывающий звонок
            public Employee Employee { get; private set; }

            // абонент этого звонка
            public Caller Caller { get; }

            // Назначить работника для обработки звонка
            public void SetHandler(Employee employee)
            {
                Employee = employee;
            }

            public Rank IncrementRank()
            {
                if (Rank.Equals(Rank.Manager))
                {
                    Rank = Rank.Director;
                }

                if (Rank.Equals(Rank.Responder))
                {
                    Rank = Rank.Manager;
                }

                return Rank;
            }

            public void Reply(string message)
            {
            }

            public void Disconnect()
            {
                Reply("Thank you for your call");
            }
        }

        // инфо об абоненте
        public class Caller
        {
        }

        public enum Rank
        {
            Responder = 0,
            Manager = 1,
            Director = 2
        }
    }
}
