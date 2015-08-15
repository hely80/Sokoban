using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokobanGame
{
    class AboxSolver
    {
        Cell[,] map;
        Cell[,] top;
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

        public AboxSolver(Cell[,] map, Cell[,] top)
        {
            this.map = map;
            this.top = top;
            w = map.GetLength(0);
            h = map.GetLength(1);
            directions = new List<Dirs>();
            directions.Add(new Dirs(-1, 0, "4"));
            directions.Add(new Dirs(1, 0, "6"));
            directions.Add(new Dirs(0, -1, "8"));
            directions.Add(new Dirs(0, 1, "2"));
        }

        public string MoveAbox(int mx, int my, int sx, int sy, int fx, int fy)
        {
            Place mouse;
            Place start;
            Place finish;
            mouse.x = mx;
            mouse.y = my;
            start.x = sx;
            start.y = sy;
            finish.x = fx;
            finish.y = fy;
            return MoveAbox(mouse, start, finish);
        }

        public string MoveAbox(Place mouse, Place start, Place finish)
        {   // mouse - где находится мышка,
            // start - где находится ящик,
            // finish - куда поместить ящик

            if (start.x == finish.x &&
                start.y == finish.y)
                return "";
            top[start.x, start.y] = Cell.none;

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

                    #region для работы со списком Dictionary
                    // MouseAbox ma;       
                    //ma.mouse = newMouse;
                    //ma.abox = newAbox;

                    //if (visited.ContainsKey(ma))
                    //     continue;
                    //visited.Add(ma, false);
                    #endregion

                    if (visited[newMouse.x, newMouse.y, newAbox.x, newAbox.y])
                        continue;
                    visited[newMouse.x, newMouse.y, newAbox.x, newAbox.y] = true;

                    Brain step = new Brain(newMouse, newAbox, brain.path + side.path);

                    if (newAbox.x == finish.x &&
                        newAbox.y == finish.y)
                    {
                        top[start.x, start.y] = Cell.abox;
                        return step.path;
                    }

                    queue.Enqueue(step);
                }
            }
            top[start.x, start.y] = Cell.abox;
            return "-";
        }

        bool InRange(Place place)
        {
            if (place.x < 0 || place.x >= w)
                return false;
            if (place.y < 0 || place.y >= h)
                return false;
            if (map[place.x, place.y] == Cell.none &&
                (top[place.x, place.y] == Cell.none ||
                top[place.x, place.y] == Cell.user))
                return true;
            if (map[place.x, place.y] == Cell.here &&
                (top[place.x, place.y] == Cell.none ||
                top[place.x, place.y] == Cell.user))
                return true;
            return false;
        }

    }
}
