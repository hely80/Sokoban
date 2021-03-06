﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokobanGame
{
    class MouseSolver
    {
        Cell[,] map;
        Cell[,] top;

        int w, h;
     
        List<Brain> directions;

        struct Brain
        {
            public int x;
            public int y;
            public string path;

            public Brain(int x, int y, string p)
            {
                this.x = x;
                this.y = y;
                path = p;
            }

            public Brain(Place place, string p)
            {
                this.x = place.x;
                this.y = place.y;
                path = p;
            }
        }

        public MouseSolver(Cell[,] map, Cell[,]top)
        {
            this.map = map;
            this.top = top;
            w = map.GetLength(0);
            h = map.GetLength(1);
            directions = new List<Brain>();
            directions.Add(new Brain(-1, 0, "4"));
            directions.Add(new Brain(1, 0, "6"));
            directions.Add(new Brain(0, -1, "8"));
            directions.Add(new Brain(0, 1, "2"));
        }

        public string MoveMouse(int sx, int sy, int fx, int fy)
        {
            Place start;
            Place finish;
            start.x = sx;
            start.y = sy;
            finish.x = fx;
            finish.y = fy;
            return MoveMouse(start, finish);
        }

        public string MoveMouse(Place start, Place finish)
        {
            Queue<Brain> queue = new Queue<Brain>(); // очередь для организации алгоритма поиска вширину
            List<Place> visited = new List<Place>(); // список вершин, гду мы уже были

            queue.Clear();
            visited.Clear();

            Brain brain;
            brain.x = start.x;
            brain.y = start.y;
            brain.path = "";

            Place place;
            queue.Enqueue(brain);

            while (queue.Count > 0)
            {
                brain = queue.Dequeue();
                foreach (Brain side in directions)
                {
                    place.x = brain.x + side.x;
                    place.y = brain.y + side.y;
                    if (!InRange(place))
                        continue;
                    if (visited.Contains(place))
                        continue;
                    visited.Add(place);

                    Brain step = new Brain(place, brain.path + side.path);

                    if (place.Equals(finish))
                        return step.path;
                    queue.Enqueue(step);
                }
            }
            return "-";
        }

        bool InRange(Place place)
        {
            if (place.x < 0 || place.x >= w)
                return false;
            if (place.y < 0 || place.y >= h)
                return false;
            if (map[place.x, place.y] == Cell.none &&
                top[place.x, place.y] == Cell.none)
                return true;
            if (map[place.x, place.y] == Cell.here &&
                top[place.x, place.y] == Cell.none)
                return true;
            return false;
        }
    }
}
