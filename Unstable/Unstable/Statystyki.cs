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
    public partial class Statystyki : Form
    {
        Launcher daneLauncher;
        public Statystyki(Launcher dane)
        {
            InitializeComponent();

            daneLauncher = dane;

            labelSiłaGracz.Text = Convert.ToString(daneLauncher.siła);
            labelZręcznośćGracz.Text = Convert.ToString(daneLauncher.zręczność);
            labelInteligencjaGracz.Text = Convert.ToString(daneLauncher.inteligencja);
            labelWytrzymałośćGracz.Text = Convert.ToString(daneLauncher.wytrzymałość);
            labelSzczęścieGracz.Text = Convert.ToString(daneLauncher.szczęście);
        }
    }
}
