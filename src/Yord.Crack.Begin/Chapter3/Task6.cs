using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.Chapter3
{
    // реализовать приют кошек и собак
    // можно взять только животное, которое провело в приюте больше всего времени
    // разрешено использовать встроенный LinkedList
    // методы DequeueCat, DequeueDog, DequeueAnimal
    public class Task6
    {
        public class Shelter
        {
            private LinkedList<Cat> _cats;
            private LinkedList<Dog> _dogs;
            private int order; // можно использовать метку времени поступления животного

            public Shelter()
            {
                _cats = new LinkedList<Cat>();
                _dogs = new LinkedList<Dog>();
            }

            public void Enqueue(Animal a)
            {
                a.Order = order;
                switch (a)
                {
                    case Cat c:
                        _cats.AddLast(c);
                        break;
                    case Dog d:
                        _dogs.AddLast(d);
                        break;
                }

                order++;
            }

            public Cat DequeueCat()
            {
                var cat = _cats.FirstOrDefault();
                if (cat != null)
                {
                    _cats.RemoveFirst();
                }

                return cat;
            }

            public Dog DequeueDog()
            {
                var dog = _dogs.FirstOrDefault();
                if (dog != null)
                {
                    _dogs.RemoveFirst();
                }

                return dog;
            }

            public Animal DequeueAnimal()
            {
                var dog = _dogs.FirstOrDefault();
                var cat = _cats.FirstOrDefault();
                if (cat == null || dog == null)
                {
                    return (Animal) cat ?? dog;
                }

                if (cat.Order < dog.Order)
                {
                    return DequeueCat();
                }

                return DequeueDog();
            }
        }

        public abstract class Animal
        {
            public string Name { get; }

            public int Order { get; set; }

            protected Animal(string name)
            {
                Name = name;
            }
        }

        public class Cat : Animal
        {
            public Cat(string name) : base(name)
            {
            }
        }

        public class Dog : Animal
        {
            public Dog(string name) : base(name)
            {
            }
        }
    }
}
