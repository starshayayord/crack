using System;
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

            // получение первого доступного работника для обработк звонка
            public Employee GetHandlerForCall(Call call)
            {
                throw new NotImplementedException();
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
                if (employee == null)
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
                throw new NotImplementedException();
            }
        }

        public abstract class Employee
        {
            private Call _currentCall;
            protected Rank Rank { get; set; }

            public Employee()
            {
            }

            // начало обработки
            public void ReceiveCall(Call call)
            {
                throw new NotImplementedException();
            }

            // проблема решена
            public void CallCompleted()
            {
            }

            // проблема осталась, передаем звонок выше, назначаем нового работника
            public void EscalateAndReassign()
            {
            }

            // Назначить вызов работнику, если он свободен
            public bool AssignNewCall()
            {
                throw new NotImplementedException();
            }

            public bool IsFree => _currentCall == null;

            public Rank GetRank => Rank;
        }

        public class Director : Employee
        {
            public Director()
            {
                Rank = Rank.Director;
            }
        }

        public class Manager : Employee
        {
            public Manager(CallHandler handler) 
            {
                Rank = Rank.Manager;
            }
        }

        public class Responder : Employee
        {
            public Responder(CallHandler handler) 
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

            public void IncrementRank()
            {
                if (Rank.Equals(Rank.Director))
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (Rank.Equals(Rank.Manager))
                {
                    Rank = Rank.Director;
                }

                if (Rank.Equals(Rank.Responder))
                {
                    Rank = Rank.Manager;
                }
            }

            public void Reply(string message)
            {
            }

            public void Disconnect()
            {
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
