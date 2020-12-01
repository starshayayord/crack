using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.Chapter4
{
    // имеется список проектов и список зависимостей, типа (A, B) - значит А зависит от B
    // вернуть правильный порядок построения проектов или null, если невозмножно
    public class Task7
    {
        //PERFECT (менее понятный)
        public static Stack<char> GetOrderDfs(char[] projects, Tuple<char, char>[] deps)
        {
            var nodes = projects.ToDictionary(p => p, p => new Project());
            foreach (var (p, d) in deps)
            {
                nodes[p].Deps.Add(d);
                nodes[p].DepsCount++;
                nodes[d].Children.Add(p);
            }

            var stack = new Stack<char>();
            //для случайного узла делаем поиск в глубину до проекта, от которого никто не зависит
            //(то есть строим случайный узел)
            //добавляем такой проект и все по цепочке
            foreach (var (pName, proj) in nodes)
            {
                //если проект еще не трогали
                if (proj.State == State.Blank)
                {
                    //пытаемся найти для него возможное построение рекурсивно
                    if (!DoDfs(nodes, pName, stack)) return null;
                }
            }

            return stack;
        }

        // Добавляем сначала узлы, от которых НЕ ЗАВИСЯТ другие проекты (которые построить последними)
        // потом добавляем текущий узел
        // повторяем, пока не пройдем по всем узлам из графа (foreach в главной функции)
        private static bool DoDfs(Dictionary<char, Project> nodes, char pName, Stack<char> stack)
        {
            // если в процессе рекурсии мы вернулись к какому-то узлу, который уже начал обрабатываться
            // то циклическая зависимость
            if (nodes[pName].State == State.Partial) return false;
            if (nodes[pName].State == State.Blank)
            {
                nodes[pName].State = State.Partial;
                // повторяем для проектов, которые зависят от текущего
                // пока у них не закончатся зависящие
                // если у кого-то из зависящих нашлась циклическая зависимость, то выходим с ошибкой
                foreach (var c in nodes[pName].Children)
                {
                    if (!DoDfs(nodes, c, stack)) return false;
                }

                // если циклической зависимость не было, то помечаем текущий как построенный и добавляет в стек
                nodes[pName].State = State.Complete;
                // благодаря рекурсии самый "независимый" будет добавлен последним
                stack.Push(pName);
            }

            return true;
        }

        // PERFECT 
        // по логике равен GetOrder2, но без дополнительных затрат
        // более понятный
        public static char?[] GetOrder(char[] projects, Tuple<char, char>[] deps)
        {
            var nodes = projects.ToDictionary(p => p, p => new Project());
            foreach (var (p, d) in deps)
            {
                nodes[p].Deps.Add(d);
                nodes[p].DepsCount++;
                nodes[d].Children.Add(p);
            }

            var order = new char?[projects.Length];
            // добавили проект(ы) без зависимостей
            var offset = AddNonDependent(order, nodes, 0, projects);
            var toBeProcessed = 0;
            //пока не запроцессили все проекты
            while (toBeProcessed < order.Length)
            {
                var current = order[toBeProcessed];
                // если текущий проект для обработки равен null, значит не смгли добавить его через AddNonDependent
                // значит у него есть циклическая зависимость
                if (current == null) return null;
                //собрали проект, значит можно уменьшить кол-во проектов, необходимых для сборки его детей, на 1
                // то есть на этот самый проект
                var children = nodes[current.Value].Children;
                foreach (var c in children)
                {
                    nodes[c].DepsCount--;
                }

                //добавим тех детей, у которых не осталось зависимтостей
                offset = AddNonDependent(order, nodes, offset, children);
                toBeProcessed++;
            }

            return order;
        }

        private class Project
        {
            public List<char> Deps = new List<char>(); // от кого зависит нода
            public int DepsCount; // осталось собрать зависимостей для сборки текущей ноды
            public List<char> Children = new List<char>(); // кто зависит от текущей ноды
            public State State = State.Blank; //только для GetOrderDfs()
        }

        private enum State
        {
            Blank,
            Partial,
            Complete
        }

        private static int AddNonDependent(char?[] order, Dictionary<char, Project> projects, int offset,
            IEnumerable<char> checkProjects)
        {
            foreach (var c in checkProjects)
            {
                var n = projects[c];
                if (n.DepsCount == 0)
                {
                    order[offset] = c;
                    offset++;
                }
            }

            return offset;
        }

        public static HashSet<char> GetOrder2(char[] projects, Tuple<char, char>[] deps)
        {
            var result = new HashSet<char>();
            var map = projects.ToDictionary(p => p, p => new List<char>());
            foreach (var (p, d) in deps)
            {
                map[p].Add(d);
            }

            while (map.Any())
            {
                var next = CanBeBuild(map, result);
                if (next == null) return null;
                result.Add(next.Value);
            }

            return result;
        }

        //всегда будет какая-то нода, у которой нет соседей. иначе проект нельзя построить из-за циклических зависимостей
        public static char? CanBeBuild(Dictionary<char, List<char>> map, HashSet<char> r)
        {
            foreach (var (c, deps) in map)
            {
                if (deps.All(d => r.Contains(d)))
                {
                    map.Remove(c);
                    return c;
                }
            }

            return null;
        }
    }
}
