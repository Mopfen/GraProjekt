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
    public partial class WczytajGrę : Form
    {
        Launcher daneLauncher;

        public WczytajGrę(Launcher dane)
        {
            InitializeComponent();

            daneLauncher = dane;

            this.Text = "TerrorOfDragons - " + daneLauncher.gameVersion;
            wersjaGry.Text += daneLauncher.gameVersion;
        }

        private void buttonWróć_Click(object sender, EventArgs e)
        {
            MenuGlowne formaMenuGlowne = new MenuGlowne(daneLauncher);

            this.Close();
            formaMenuGlowne.Show();
        }
    }
}
