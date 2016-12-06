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

            sprawdzPrzyciski();
            aktualizuj();
        }

        private void Statystyki_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C | e.KeyCode == Keys.Escape)
            {
                Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
                metodaUniwersalne.uruchomTimery();
                this.Close();
            }
        }

        private void alaButtonExit_Click(object sender, EventArgs e)
        {
            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
            metodaUniwersalne.uruchomTimery();
            this.Close();
        }

        private void alaButtonAddSił_Click(object sender, EventArgs e)
        {
            daneLauncher.daneGracz.siła++;
            daneLauncher.daneGracz.statystykiDoRozdania--;
            sprawdzPrzyciski();
            aktualizuj();
        }

        private void alaButtonAddZrę_Click(object sender, EventArgs e)
        {
            daneLauncher.daneGracz.zręczność++;
            daneLauncher.daneGracz.statystykiDoRozdania--;
            sprawdzPrzyciski();
            aktualizuj();
        }

        private void alaButtonAddInt_Click(object sender, EventArgs e)
        {
            daneLauncher.daneGracz.inteligencja++;
            daneLauncher.daneGracz.statystykiDoRozdania--;
            sprawdzPrzyciski();
            aktualizuj();
        }

        private void alaButtonAddWyt_Click(object sender, EventArgs e)
        {
            daneLauncher.daneGracz.wytrzymałość++;
            daneLauncher.daneGracz.statystykiDoRozdania--;
            sprawdzPrzyciski();
            aktualizuj();
        }

        private void alaButtonAddSzc_Click(object sender, EventArgs e)
        {
            daneLauncher.daneGracz.szczęście++;
            daneLauncher.daneGracz.statystykiDoRozdania--;
            sprawdzPrzyciski();
            aktualizuj();
        }

        private void aktualizuj()
        {
            MetodyStatystyki metodaStatystyki = new MetodyStatystyki(daneLauncher);
            metodaStatystyki.liczStatystyki();

            labelSiłaGracz.Text = Convert.ToString(daneLauncher.daneGracz.siła);
            labelZręcznośćGracz.Text = Convert.ToString(daneLauncher.daneGracz.zręczność);
            labelInteligencjaGracz.Text = Convert.ToString(daneLauncher.daneGracz.inteligencja);
            labelWytrzymałośćGracz.Text = Convert.ToString(daneLauncher.daneGracz.wytrzymałość);
            labelSzczęścieGracz.Text = Convert.ToString(daneLauncher.daneGracz.szczęście);
            labelDmgZwarcieGracz.Text = Convert.ToString(daneLauncher.daneGracz.siłaAtakuZwarcie[0] + "-" + daneLauncher.daneGracz.siłaAtakuZwarcie[1]);
            labelDmgDystansGracz.Text = Convert.ToString(daneLauncher.daneGracz.siłaAtakuDystans[0] + "-" + daneLauncher.daneGracz.siłaAtakuDystans[1]);
            labelHpGracz.Text = Convert.ToString(daneLauncher.daneGracz.hp + "/" + daneLauncher.daneGracz.hpMax);
            labelManaGracz.Text = Convert.ToString(daneLauncher.daneGracz.mana + "/" + daneLauncher.daneGracz.manaMax);
            labelKrytykGracz.Text = Convert.ToString(daneLauncher.daneGracz.szansaKryta + "%");
        }

        private void sprawdzPrzyciski()
        {
            if (daneLauncher.daneGracz.statystykiDoRozdania > 0)
            {
                alaButtonAddSił.Visible = alaButtonAddZrę.Visible = alaButtonAddInt.Visible = alaButtonAddWyt.Visible = alaButtonAddSzc.Visible = true;
            }
            else
            {
                alaButtonAddSił.Visible = alaButtonAddZrę.Visible = alaButtonAddInt.Visible = alaButtonAddWyt.Visible = alaButtonAddSzc.Visible = false;
            }
        }
    }
}
