using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SokobanGame
{
    public delegate void deShowItem(Place place, Cell item);
    public delegate void deShowStat(int placed, int totals);

    public partial class Labirint : Form
    {
        int level_nr;
        int last_level_nr;

        int width, height;
        PictureBox[,] box;
        LogicGame game;
        Phone phone;

        int mode;
        int my_user;
        int ot_user;

        public Labirint(string port) // Server
        {
            mode = 2;
            phone = new PhoneServer(int.Parse(port));
            phone.Recv += Recv;
            phone.Start();
            my_user = 1;
            ot_user = 2;
            Init();
        }

        public Labirint(string host, string port) // Client
        {
            mode = 2;
            phone = new PhoneClient(host, int.Parse(port));
            phone.Recv += Recv;
            phone.Start();
            my_user = 2;
            ot_user = 1;
            Init();
        }

        public Labirint() // Одиночная игра (Single mode)
        {
            mode = 1;
            my_user = 1;
            ot_user = 1;
            Init();
        }

        public Labirint(int two) // Игра вдвоем на одном ПК (Double mode)
        {
            mode = 3;
            my_user = 1;
            ot_user = 2;
            Init();
        }

        public void Init()
        {
            InitializeComponent();
            last_level_nr = 17;
            game = new LogicGame(mode, ShowItem, ShowStat);
        }

        public void OpenLevel(int level_nr)
        {
            if (level_nr < 1)
                return;
            if (level_nr > last_level_nr)
                return;

            this.level_nr = level_nr;

            if (!game.Init(level_nr, out width, out height))
            {
                FinighSocoban win = new FinighSocoban();
                win.ShowDialog();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                return;
            }
           
            InitPictures();
            game.ShowLevel();
        }

        public void InitPictures()  // создает элементы
        {
            box = new PictureBox[width, height];
            int bw, bh;
            bw = panel.Width / width;
            bh = panel.Height / height;
            if (bw < bh)
                bh = bw;
            else
                bw = bh;
            box = new PictureBox[width, height];
            panel.Controls.Clear();
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                {
                    PictureBox picture = new PictureBox();
                    picture.BackColor = System.Drawing.Color.Transparent;
                    picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    picture.Location = new System.Drawing.Point(x * (bw - 1), y * (bh - 1));
                    picture.Size = new System.Drawing.Size(bw, bh);
                    picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    picture.MouseClick += new System.Windows.Forms.MouseEventHandler(Picture_MouseClick);
                    picture.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(Picture_MouseDorbleClick);
                    picture.Tag = new Place(x, y);
                    panel.Controls.Add(picture);
                    box[x, y] = picture;
                }
        }

        public void ShowItem(Place place, Cell item)
        {
            box[place.x, place.y].Image = CellToPicture(item);
        }

        public void ShowStat(int placed, int totals)
        {
            toolStat.Text = placed.ToString() + " из " + totals.ToString();
            toolLevel.Text = level_nr.ToString(); 
            toolDone.Visible = placed == totals;
            if (placed == totals)
                {
                    if (level_nr == last_level_nr)
                        last_level_nr = level_nr + 1;
                }
        }

        private Image CellToPicture(Cell c)
        {
            switch (c)
            {
                case Cell.none: return Properties.Resources.none;
                case Cell.wall: return Properties.Resources.wall;
                case Cell.abox: return Properties.Resources.abox;
                case Cell.here: return Properties.Resources.here;
                case Cell.done: return Properties.Resources.done;
                case Cell.user1: return Properties.Resources.user1;
                case Cell.user2: return Properties.Resources.user2;
                default: return Properties.Resources.none;
            }
        }

        private void toolPrevLevel_Click(object sender, EventArgs e)
        {
            if (!phoneSend(3))
                return;
            OpenLevel(level_nr - 1);
        }

        private void toolNextLevel_Click(object sender, EventArgs e)
        {
            if (!phoneSend(9))
                return;
            OpenLevel(level_nr + 1);
        }

        private void Labirint_KeyDown(object sender, KeyEventArgs e)
        {
            if (path != "")
            {
                path = "";
                return;
            }
            switch(e.KeyCode)
            {
                case Keys.Left:    if (phoneSend(4)) game.Step(my_user, -1, 0); break;
                case Keys.Right:   if (phoneSend(6)) game.Step(my_user, 1, 0); break;
                case Keys.Down:    if (phoneSend(2)) game.Step(my_user, 0, 1); break;
                case Keys.Up:      if (phoneSend(8)) game.Step(my_user, 0, -1); break;

                case Keys.A: if (mode == 3) game.Step(ot_user, -1, 0); break;
                case Keys.D: if (mode == 3) game.Step(ot_user, 1, 0); break;
                case Keys.S: if (mode == 3) game.Step(ot_user, 0, 1); break;
                case Keys.W: if (mode == 3) game.Step(ot_user, 0, -1); break;

                case Keys.Escape: if (phoneSend(0)) RestarLevel(); break;
            }
        }

        private bool phoneSend(byte nr)
        {
            if (mode == 2)
                return phone.Send(nr);
            return true;
        }

        private void Recv(byte data)
        {
            switch (data)
            {
                case 4: game.Step(ot_user, -1, 0); break;
                case 6: game.Step(ot_user, 1, 0); break;
                case 2: game.Step(ot_user, 0, 1); break;
                case 8: game.Step(ot_user, 0, -1); break;

                case 0: RestarLevel(); break;

                case 3: path = "3"; break;
                case 9: path = "9"; break;
            }
        }

        private void RestarLevel()
        {
            game.Init(level_nr, out width, out height);
            game.ShowLevel();
        }

        private void toolRestart_Click(object sender, EventArgs e)
        {
            RestarLevel();
        }

        private void panel_Resize(object sender, EventArgs e)
        {
            int bw, bh;
            bw = panel.Width / width;
            bh = panel.Height / height;
            if (bw < bh)
                bh = bw;
            else
                bw = bh;
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                {
                    box[x,y].Location = new System.Drawing.Point(x * (bw - 1), y * (bh - 1));
                    box[x,y].Size = new System.Drawing.Size(bw, bh);
                }
        }

        private void Picture_MouseClick(object sender, MouseEventArgs e)
        {
            Place place = (Place)((PictureBox)sender).Tag;
            string my_path;
            if (abox.x == -1)
                my_path = game.SolveMouse(my_user, place);
            else
            {
                my_path = game.SolveAbox(my_user, abox, place);
                abox.x = -1;
                abox.y = -1;
            }
            path = my_path; 
        }

        Place abox = new Place(-1, -1);

        private void Picture_MouseDorbleClick(object sender, MouseEventArgs e)
        {
            abox = (Place)((PictureBox)sender).Tag; 
        }

        string path = "";

        private void timer_Tick(object sender, EventArgs e)
        {
            if (path == "3")
            {
                OpenLevel(level_nr - 1);
                path = "";
            }
            if (path == "9")
            {
                OpenLevel(level_nr + 1);
                path = "";
            }

            if (path == "")
                return;
            switch (path[0])
            {
                case '4': game.Step(my_user, -1, 0); break;
                case '6': game.Step(my_user, 1, 0); break;
                case '2': game.Step(my_user, 0, 1); break;
                case '8': game.Step(my_user, 0, -1); break;
            }
            path = path.Substring(1);
        }
    }
}
