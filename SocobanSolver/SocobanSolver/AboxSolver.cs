using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocobanSolver
{
    public class AboxSolver
    {
        char[,] map;
        int w, h;
      
        List<Dirs> directions;

        struct MouseAbox
        {
            public Place mouse;
            public Place abox;
        }

        struct Brain
        {
            public Place mouse;
            public Place abox;
            public string path;

            public Brain(Place mouse, Place abox, string p)
            {
                this.mouse = mouse;
                this.abox = abox;
                path = p;
            }
        }

        struct Dirs
        {
            public int x;
            public int y;
            public string path;

            public Dirs(int x, int y, string p)
            {
                this.x = x;
                this.y = y;
                path = p;
            }
        }

        public AboxSolver(char[,] map)
        {
            this.map = map;
            w = map.GetLength(0);
            h = map.GetLength(1);
            directions = new List<Dirs>();
            directions.Add(new Dirs(-1, 0, "4"));
            directions.Add(new Dirs(1, 0, "6"));
            directions.Add(new Dirs(0, -1, "8"));
            directions.Add(new Dirs(0, 1, "2"));
        }

        public string MoveAbox(Place mouse, Place start, Place finish)
        {   // mouse - где находится мышка,
            // start - где находится ящик,
            // finish - куда поместить ящик

            if (start.x == finish.x &&
                start.y == finish.y)
                return "";
            map[start.x, start.y] = ' ';

            bool[, , ,] visited = new bool[w, h, w, h];

            Queue<Brain> queue = new Queue<Brain>(); // очередь для организации алгоритма поиска вширину
           // Dictionary<MouseAbox, bool> visited = new Dictionary<MouseAbox, bool>(); // список положения мышки и ящика, гду мы уже были

            queue.Clear();
            //visited.Clear();

            Brain brain;
            brain.mouse = mouse;
            brain.abox = start;
            brain.path = "";

            Place newMouse;
            Place newAbox;
            
            queue.Enqueue(brain);

            while (queue.Count > 0)
            {
                brain = queue.Dequeue();
                foreach (Dirs side in directions)
                {
                    newMouse.x = brain.mouse.x + side.x;
                    newMouse.y = brain.mouse.y + side.y;

                    if (!InRange(newMouse))
                        continue;

                    if (newMouse.x == brain.abox.x &&
                        newMouse.y == brain.abox.y)
                    {
                        newAbox.x = newMouse.x + side.x;
                        newAbox.y = newMouse.y + side.y;
                        if (!InRange(newAbox))
                            continue;
                    }
                    else
                        newAbox = brain.abox;

                    // MouseAbox ma;               //  для работы со списком Dictionary
                    //ma.mouse = newMouse;
                    //ma.abox = newAbox;

                    //if (visited.ContainsKey(ma))
                    //     continue;
                    //visited.Add(ma, false);

                    if (visited[newMouse.x, newMouse.y, newAbox.x, newAbox.y])
                        continue;
                    visited[newMouse.x, newMouse.y, newAbox.x, newAbox.y] = true;

                    Brain step = new Brain(newMouse, newAbox, brain.path + side.path);

                    if (newAbox.x == finish.x &&
                        newAbox.y == finish.y)
                        return step.path;

                    queue.Enqueue(step);
                }
            }
            return "NO";
        }

        bool InRange(Place place)
        {
            if (place.x < 0 || place.x >= w)
                return false;
            if (place.y < 0 || place.y >= h)
                return false;
            if (map[place.x, place.y] != ' ')
                return false;
            return true;
        }

    }
}
