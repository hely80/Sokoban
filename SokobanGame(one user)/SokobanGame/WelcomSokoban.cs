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
    public partial class WelcomSokoban : Form
    {
        public WelcomSokoban()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Labirint labirint = new Labirint();
            labirint.OpenLevel(1);
            labirint.ShowDialog();
        }
    }
}
