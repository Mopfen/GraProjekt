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

            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
            metodaUniwersalne.dmgZwarcieGracz1();
            metodaUniwersalne.dmgZwarcieGracz2();
            metodaUniwersalne.dmgDystansGracz1();
            metodaUniwersalne.dmgDystansGracz2();

            labelSiłaGracz.Text = Convert.ToString(daneLauncher.daneGracz[0].siła);
            labelZręcznośćGracz.Text = Convert.ToString(daneLauncher.daneGracz[0].zręczność);
            labelInteligencjaGracz.Text = Convert.ToString(daneLauncher.daneGracz[0].inteligencja);
            labelWytrzymałośćGracz.Text = Convert.ToString(daneLauncher.daneGracz[0].wytrzymałość);
            labelSzczęścieGracz.Text = Convert.ToString(daneLauncher.daneGracz[0].szczęście);
            labelDmgZwarcieGracz.Text = Convert.ToString(daneLauncher.daneGracz[0].siłaAtakuZwarcie[0]+"-"+daneLauncher.daneGracz[0].siłaAtakuZwarcie[1]);
            labelDmgDystansGracz.Text = Convert.ToString(daneLauncher.daneGracz[0].siłaAtakuDystans[0]+"-"+daneLauncher.daneGracz[0].siłaAtakuDystans[1]);
            labelHpGracz.Text = Convert.ToString(daneLauncher.daneGracz[0].hp +"/"+daneLauncher.daneGracz[0].hpMax);
        }

        private void Statystyki_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C | e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
