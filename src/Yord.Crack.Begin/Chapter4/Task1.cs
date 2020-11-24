using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.Chapter4
{
    // для заданного направленного графа проверить существование маршрута между двумя узлами
    public class Task1
    {
        //PERFECT
        public enum State
        {
            Unvisited,
            Visited,
            Visiting
        }

        public class Graph<T>
        {
            public GraphNode[] Nodes;

            public class GraphNode
            {
                public T Value;

                public State State = State.Unvisited;

                public GraphNode[] Adjacents = Array.Empty<GraphNode>();
            }
        }

        // PERFECT
        // По сути - BFS, то есть проверяет соседей.
        // DFS решение тоже возможно, но ухоит слишком глубоко до проверки ближайших соседей
        public static bool IsConnected(Graph<int>.GraphNode n1, Graph<int>.GraphNode n2)
        {
            if (n1 == n2) return true;
            var q = new Queue<Graph<int>.GraphNode>();
            n1.State = State.Visiting; // флаг, чтоб не проверять одни и те же ноды
            q.Enqueue(n1);
            while (q.Any())
            {
                var n = q.Dequeue();
                foreach (var c in n.Adjacents)
                {
                    if (c.State == State.Unvisited)
                    {
                        if (c == n2) return true;
                        c.State = State.Visiting;
                        q.Enqueue(c);
                    }
                }

                n.State = State.Visited;
            }

            return false;
        }
    }
}
