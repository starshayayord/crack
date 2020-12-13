using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.Chapter4
{
    public class Graph<T>
    {
        public GraphNode[] Nodes;

        public class GraphNode
        {
            public T Value;
            
            public bool Marked { get; set; }

            public GraphNode[] Children = Array.Empty<GraphNode>();
        }

        // сначала проходит всех соседей соседей соседей..., т.е.
        // полностью проходит ветвь, прежде чем переходить к непосредственному соседу текущего узла
        public void Dfs(GraphNode root)
        {
            if (root == null) return;
            Visit(root);
            root.Marked = true;
            foreach (var n in root.Children)
            {
                if (!n.Marked)
                {
                    Dfs(n);
                }
            }
        }

        // все соседи текущей ноды проверяются раньше их соседей
        public void Bfs(GraphNode root)
        {
            if (root == null) return;
            var queue = new Queue<GraphNode>();
            root.Marked = true;
            queue.Enqueue(root);
            while (queue.Any())
            {
                var n = queue.Dequeue();
                Visit(n);
                foreach (var c in n.Children)
                {
                    if (!c.Marked)
                    {
                        c.Marked = true;
                        queue.Enqueue(c);
                    }
                }
            }
        }

        private void Visit(GraphNode node)
        {
            
        }
    }
}
