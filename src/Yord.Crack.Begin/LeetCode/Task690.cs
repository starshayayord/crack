using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    public class Task690
    {
        public class Employee {
            public int id;
            public int importance;
            public IList<int> subordinates;
        }
        
        public static int GetImportance(IList<Employee> employees, int id)
        {
            var q = new Queue<int>();
            q.Enqueue(id);
            var map = employees.ToDictionary(employee => employee.id);
            int s = 0;
            while (q.Any())
            {
                var e = map[q.Dequeue()];
                s+=e.importance;
                foreach (var eSub in e.subordinates)
                {
                    q.Enqueue(eSub);
                }
            }

            return s;

        }

        public static int GetImportanceDfs(IList<Employee> employees, int id)
        {
            var map = employees.ToDictionary(employee => employee.id);
            return Dfs(id, map);
        }
        

        private static int Dfs(int eid, Dictionary<int, Employee> map)
        {
            var emp = map[eid];
            return emp.importance + emp.subordinates.Sum(sub => Dfs(map[sub].id, map));
        }
    }
}
