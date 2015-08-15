using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokobanGame
{
    class LevelFile
    {
        int mode;

        public LevelFile(int mode)
        {
            this.mode = mode;
        }

        public Cell[,] LoadLevel(int level_nr)
        {
            Cell[,] cell = null;
            string[] lines;
            string[] nl = { "\r\n" };
           if (mode == 1)
               lines = Properties.Resources.levels1.Split(nl, StringSplitOptions.None);
           else 
               lines = Properties.Resources.level2.Split(nl, StringSplitOptions.None);
            int curr = 0;
            int curr_level_nr = 0;
            int width;
            int height;
            while (curr < lines.Length)
            {
                ReadLevelHeader(lines[curr], out curr_level_nr, out width, out height);
                if (level_nr == curr_level_nr)
                {
                    cell = new Cell[width, height];
                    for (int y = 0; y < height; y++)
                        for (int x = 0; x < width; x++)
                            cell[x, y] = CharToCell(lines[curr + 1 + y][x]);
                    break;
                }
                else
                    curr = curr + 1 + height;
            }
            return cell;
        }

        private void ReadLevelHeader(string line, out int level_nr, out int width, out int height)
        {
            string[] parts = line.Split();
            level_nr = 0;
            width = 0;
            height = 0;
            if (parts.Length != 3)
                return;
            int.TryParse(parts[0], out level_nr);
            int.TryParse(parts[1], out width);
            int.TryParse(parts[2], out height);
        }

        public Cell CharToCell(char x)
        {
            switch (x)
            {
                case ' ': return Cell.none;
                case '#': return Cell.wall;
                case '0': return Cell.abox;
                case '.': return Cell.here;
                case 'C': return Cell.done;
                case '1': return Cell.user1;
                case '2': return Cell.user2;
                default: return Cell.none;
            }
        }

        public char CellToChar(Cell c)
        {
            switch (c)
            {
                case Cell.none: return ' ';
                case Cell.wall: return '#';
                case Cell.abox: return '0';
                case Cell.here: return '.';
                case Cell.done: return 'C';
                case Cell.user1: return '1';
                case Cell.user2: return '2';
                default: return ' ';
            }
        }
    }
}
