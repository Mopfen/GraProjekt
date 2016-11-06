using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unstable
{
    public partial class GameOver : Form
    {
        Launcher daneLauncher;
        Form daneForma;
        public GameOver(Launcher dane, Form forma)
        {
            InitializeComponent();
            daneLauncher = dane;
            daneForma = forma;
        }

        private void GameOver_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                daneForma.Close();
                daneLauncher.Show();
            }
        }
    }
}
