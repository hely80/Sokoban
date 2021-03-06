﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SokobanGame
{
    public struct Place
    {
        public int x;
        public int y;

        public Place(int ax, int ay)
        {
            x = ax;
            y = ay;
        }
    }

    public enum Cell
    {
        none,
        wall,
        abox,
        done,
        here,
        user
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WelcomSokoban());
        }
    }
}
