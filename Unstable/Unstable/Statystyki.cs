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
                daneLauncher.timerStatystyki.Enabled = true;
                this.Close();
            }
            //if (e.KeyCode == Keys.I)
            //{
            //    daneLauncher.timerStatystyki.Enabled = true;
            //    this.Close();
            //    Ekwipunek formaEkwipunek = new Ekwipunek(daneLauncher);
            //    formaEkwipunek.ShowDialog();
            //}
        }

        private void alaButtonExit_Click(object sender, EventArgs e)
        {
            daneLauncher.timerStatystyki.Enabled = true;
            this.Close();
        }

        private void alaButtonAddSił_Click(object sender, EventArgs e)
        {
            daneLauncher.daneGracz[0].siła++;
            daneLauncher.daneGracz[0].statystykiDoRozdania--;
            sprawdzPrzyciski();
            aktualizuj();
        }

        private void alaButtonAddZrę_Click(object sender, EventArgs e)
        {
            daneLauncher.daneGracz[0].zręczność++;
            daneLauncher.daneGracz[0].statystykiDoRozdania--;
            sprawdzPrzyciski();
            aktualizuj();
        }

        private void alaButtonAddInt_Click(object sender, EventArgs e)
        {
            daneLauncher.daneGracz[0].inteligencja++;
            daneLauncher.daneGracz[0].statystykiDoRozdania--;
            sprawdzPrzyciski();
            aktualizuj();
        }

        private void alaButtonAddWyt_Click(object sender, EventArgs e)
        {
            daneLauncher.daneGracz[0].wytrzymałość++;
            daneLauncher.daneGracz[0].statystykiDoRozdania--;
            sprawdzPrzyciski();
            aktualizuj();
        }

        private void alaButtonAddSzc_Click(object sender, EventArgs e)
        {
            daneLauncher.daneGracz[0].szczęście++;
            daneLauncher.daneGracz[0].statystykiDoRozdania--;
            sprawdzPrzyciski();
            aktualizuj();
        }

        private void aktualizuj()
        {
            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
            metodaUniwersalne.liczStatystyki();

            labelSiłaGracz.Text = Convert.ToString(daneLauncher.daneGracz[0].siła);
            labelZręcznośćGracz.Text = Convert.ToString(daneLauncher.daneGracz[0].zręczność);
            labelInteligencjaGracz.Text = Convert.ToString(daneLauncher.daneGracz[0].inteligencja);
            labelWytrzymałośćGracz.Text = Convert.ToString(daneLauncher.daneGracz[0].wytrzymałość);
            labelSzczęścieGracz.Text = Convert.ToString(daneLauncher.daneGracz[0].szczęście);
            labelDmgZwarcieGracz.Text = Convert.ToString(daneLauncher.daneGracz[0].siłaAtakuZwarcie[0] + "-" + daneLauncher.daneGracz[0].siłaAtakuZwarcie[1]);
            labelDmgDystansGracz.Text = Convert.ToString(daneLauncher.daneGracz[0].siłaAtakuDystans[0] + "-" + daneLauncher.daneGracz[0].siłaAtakuDystans[1]);
            labelHpGracz.Text = Convert.ToString(daneLauncher.daneGracz[0].hp + "/" + daneLauncher.daneGracz[0].hpMax);
            labelManaGracz.Text = Convert.ToString(daneLauncher.daneGracz[0].mana + "/" + daneLauncher.daneGracz[0].manaMax);
            labelKrytykGracz.Text = Convert.ToString(daneLauncher.daneGracz[0].szansaKryta + "%");
        }
        private void sprawdzPrzyciski()
        {
            if (daneLauncher.daneGracz[0].statystykiDoRozdania > 0)
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
