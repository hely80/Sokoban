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
            radioServer.Checked = false;
            radioClient.Checked = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!radioSingle.Checked &&
                !radioDouble.Checked &&
                !radioClient.Checked &&
                !radioServer.Checked)
            {
                MessageBox.Show("Выберете режим подключения!", "Ошибка");
                return;
            }

            Labirint labirint = null;
            if (radioSingle.Checked)
                labirint = new Labirint();
            if (radioDouble.Checked)
                labirint = new Labirint(2);
            if (radioServer.Checked)
                labirint = new Labirint(textPort.Text);
            if (radioClient.Checked)
                labirint = new Labirint(textHost.Text, textPort.Text);

            labirint.OpenLevel(1);
            labirint.ShowDialog();
        }

        private void radioServer_CheckedChanged(object sender, EventArgs e)
        {
            labelHost.Visible = false;
            textHost.Visible = false;
            labelPort.Visible = true;
            textPort.Visible = true;
        }

        private void radioClient_CheckedChanged(object sender, EventArgs e)
        {
            labelHost.Visible = true;
            textHost.Visible = true;
            labelPort.Visible = true;
            textPort.Visible = true;
        }

        private void radioSingle_CheckedChanged(object sender, EventArgs e)
        {
            labelHost.Visible = false;
            textHost.Visible = false;
            labelPort.Visible = false;
            textPort.Visible = false;
        }
    }
}
