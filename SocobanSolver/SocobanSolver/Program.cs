using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocobanSolver
{
    public struct Place
    {
        public int x;
        public int y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
            
        }

        char[,] map;
        int w;
        int h;

        Place mouse;
        Place abox;
        Place home;

        void Run()
        {
            LoadLabirint();
            //AlfaSolver alfaSolver = new AlfaSolver(map);
            //string path = alfaSolver.MoveAlfa(mouse, home);

            Stopwatch watch = new Stopwatch();
            watch.Start();
            AboxSolver aboxSolver = new AboxSolver(map);
            string path = aboxSolver.MoveAbox(mouse, abox, home);
            Console.WriteLine("Time: " + watch.ElapsedMilliseconds);
            Console.WriteLine(path);
            Console.ReadKey();
        }

        void LoadLabirint()
        {
            string[] lines;
            lines = File.ReadAllLines("labirint.txt");
            string[] info = lines[0].Split();
            w = int.Parse(info[0]);
            h = int.Parse(info[1]);
            map = new char[w, h];
            for (int y = 0; y < h; y++)
                for (int x = 0; x < w; x++)
                {
                    map[x, y] = lines[y + 1][x];
                    if (map[x,y] == 'A')
                    {
                        mouse.x = x;
                        mouse.y = y;
                        map[x, y] = ' ';
                    }
                    if (map[x,y] == '0')
                    {
                        abox.x = x;
                        abox.y = y;
                    }
                    if ( map[x,y] == '.')
                    {
                        home.x = x;
                        home.y = y;
                        map[x, y] = ' ';
                    }
                }
        }
    }
}
