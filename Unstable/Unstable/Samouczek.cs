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
    public partial class Samouczek : Form
    {
        Launcher daneLauncher;

        public Samouczek(Launcher dane)
        {
            InitializeComponent();

            daneLauncher = dane;
        }

        private void buttonDalej_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
