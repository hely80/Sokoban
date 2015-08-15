using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokobanGame
{
    class LogicGame
    {
        Cell[,] map;
        Cell[,] top;

        int w, h;

        deShowItem ShowItem;
        deShowStat ShowStat;

        Place[] mouse = new Place[3];

        int mode;
        int placed, totals;

        public LogicGame(int mode, deShowItem ShowItem, deShowStat ShowStat)
        {
            this.mode = mode;
            this.ShowItem = ShowItem;
            this.ShowStat = ShowStat;
        }

        public bool Init(int level_nr, out int widht, out int height)
        {
            LevelFile level = new LevelFile(mode);
            map = level.LoadLevel(level_nr);
            if (map == null)
            {
                widht = 0;
                height = 0;
                return false;
            }
            widht = w =  map.GetLength(0);
            height = h= map.GetLength(1);
            top = new Cell[widht, height];

            for (int x = 0; x < w; x++)
                for (int y = 0; y < h; y++)
                {
                    switch(map[x,y])
                    {
                        case Cell.user1:
                                        mouse [1] = new Place(x, y);
                                        map[x, y] = Cell.none;
                                        top[x, y] = Cell.user1;
                                        break;
                        case Cell.user2:
                                        mouse[2] = new Place(x, y);
                                        map[x, y] = Cell.none;
                                        top[x, y] = Cell.user2;
                                        break;
                        case Cell.none:
                        case Cell.wall:
                        case Cell.here:
                                        top[x, y] = Cell.none;
                                        break;
                        case Cell.abox:
                                        top[x, y] = Cell.abox;
                                        map[x, y] = Cell.none;
                                        break;
                        case Cell.done:
                                        top[x, y] = Cell.abox;
                                        map[x, y] = Cell.here;
                                        break;
                    }
                }
            return true;
        }

        public void ShowLevel()
        {
            placed = 0;
            totals = 0;
            for (int x = 0; x < w; x++)
                for (int y = 0; y < h; y++)
                {
                    ShowMapTop(x, y);
                    if(map[x,y] == Cell.here)
                    {
                        totals++;
                        if (top[x, y] == Cell.abox)
                            placed++;
                    }
                }
            ShowStat(placed, totals);
        }

        private void ShowMapTop(int x, int y)
        {
            if (top[x, y] == Cell.none)
                ShowItem(new Place(x, y), map[x, y]);
            else
                if (top[x, y] == Cell.abox && map[x, y] == Cell.here)
                    ShowItem(new Place(x, y), Cell.done);
                else
                    ShowItem(new Place(x, y), top[x, y]);
        }

        public void Step(int user_nr, int sx, int sy)
        {
            if (user_nr < 1 || user_nr > 2)
                return;
            Place place = new Place(mouse[user_nr].x + sx, mouse[user_nr].y + sy);
            if (!InRange(place))
                return;
            if(top[place.x, place.y] == Cell.none)
            {
                top[mouse[user_nr].x, mouse[user_nr].y] = Cell.none; ShowMapTop(mouse[user_nr].x, mouse[user_nr].y);
                top[place.x, place.y] = CellUser(user_nr); ShowMapTop(place.x, place.y);
                mouse[user_nr] = place;
            }
            if (top[place.x, place.y] == Cell.abox)
            {
                Place after = new Place(place.x + sx, place.y + sy);
                if (!InRange(after))
                    return;
                if (top[after.x, after.y] != Cell.none)
                    return;

                if (map[place.x, place.y] == Cell.here) placed--;
                if (map[after.x, after.y] == Cell.here) placed++;
                ShowStat(placed, totals);

                top[mouse[user_nr].x, mouse[user_nr].y] = Cell.none; ShowMapTop(mouse[user_nr].x, mouse[user_nr].y);
                top[place.x, place.y] = CellUser(user_nr); ShowMapTop(place.x, place.y);
                top[after.x, after.y] = Cell.abox; ShowMapTop(after.x, after.y);
                mouse[user_nr] = place;
            }
        }

        private Cell CellUser(int user_nr)
        {
            if (user_nr == 1)
                return Cell.user1;
            else
                return Cell.user2;
        }

        public bool InRange(Place place)
        {
            if (place.x < 0 || place.x >= w)
                return false;
            if (place.y < 0 || place.y >= h)
                return false;
            if (map[place.x, place.y] == Cell.none)
                return true;
            if (map[place.x, place.y] == Cell.here)
                return true;
            return false;
        }

        public string SolveMouse(int user_nr, Place to_place)
        {
            if (mode == 2)
                return "";
            if (!InRange(to_place))
                return "";
            MouseSolver solver = new MouseSolver(map, top);
            return solver.MoveMouse(mouse[user_nr], to_place);
        }

        public string SolveAbox(int user_nr,Place abox, Place to_place)
        {
            if (mode == 2)
                return "";
            if (top[abox.x, abox.y] != Cell.abox)
                return "";
            if (!InRange(to_place))
                return "";
            AboxSolver solver = new AboxSolver(map, top);
            return solver.MoveAbox(mouse[user_nr], abox, to_place);
        }
    }
}