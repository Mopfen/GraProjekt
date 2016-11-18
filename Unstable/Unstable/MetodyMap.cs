using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unstable
{
    /// <summary>
    /// Zawiera główne polecenia wykonywane w formach podczas gry
    /// </summary>
    class MetodyMap
    {
        Launcher daneLauncher;

        public MetodyMap(Launcher dane)
        {
            daneLauncher = dane;
        }
        /// <summary>
        /// Metoda wykonująca czynności po wciśnięciu ustalonych klawiszy
        /// </summary>
        internal void KeyDownMetoda(Form forma, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) { daneLauncher.daneGracz.up = true; }
            if (e.KeyCode == Keys.Down) { daneLauncher.daneGracz.down = true; }
            if (e.KeyCode == Keys.Left) { daneLauncher.daneGracz.left = true; }
            if (e.KeyCode == Keys.Right) { daneLauncher.daneGracz.right = true; }
            if (e.KeyCode == Keys.Space) daneLauncher.daneGracz.attack = true;
            if (e.KeyCode == Keys.Escape)
            {
                MenuGlowne formaMenuGlowne = new MenuGlowne(daneLauncher);

                forma.Close();
                formaMenuGlowne.Show();
            }
            if (e.KeyCode == Keys.X)
            {
                if (daneLauncher.daneGracz.rodzajAtaku == true) daneLauncher.daneGracz.rodzajAtaku = false;
                else daneLauncher.daneGracz.rodzajAtaku = true;
            }
            if (e.KeyCode == Keys.C)
            {
                Statystyki formaStatystyki = new Statystyki(daneLauncher);
                formaStatystyki.ShowDialog();
            }
            if (e.KeyCode == Keys.I)
            {
                Ekwipunek formaEkwipunek = new Ekwipunek(daneLauncher);
                formaEkwipunek.ShowDialog();
            }
            if (e.KeyCode == Keys.Z)
            {
                Uniwersalne metodyUniwersalne = new Uniwersalne(daneLauncher);
                metodyUniwersalne.podnieśDrop();
            }

        }
        /// <summary>
        /// Metoda wykonująca czynności po puszczeniu ustalonych klawiszy
        /// </summary>
        internal void KeyUpMetoda(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                daneLauncher.daneGracz.up = false; daneLauncher.daneGracz.zmianaKierunkuUp = false;
            }
            if (e.KeyCode == Keys.Down) { daneLauncher.daneGracz.down = false; daneLauncher.daneGracz.zmianaKierunkuDown = false; }
            if (e.KeyCode == Keys.Left) { daneLauncher.daneGracz.left = false; daneLauncher.daneGracz.zmianaKierunkuLeft = false; }
            if (e.KeyCode == Keys.Right) { daneLauncher.daneGracz.right = false; daneLauncher.daneGracz.zmianaKierunkuRight = false; }
        } 
        /// <summary>
        /// Metoda wykonująca czynności w timerGracz
        /// </summary>
        internal void timerGraczMetoda()
        {
            Gracz metodaGracz = new Gracz(daneLauncher);
            metodaGracz.RuchGracza();
        }
        /// <summary>
        /// Metoda wykonująca czynności w timerAtakGracz
        /// </summary>
        internal void timerAtakGraczMetoda(Timer timerGracz)
        {
            Gracz metodaGracz = new Unstable.Gracz(daneLauncher);
            metodaGracz.AtakGracza(timerGracz);
        }
        /// <summary>
        /// Metoda wykonująca czynności w timerStatystyki
        /// </summary>
        internal void timerStatystykiMetoda(Form forma, Timer timerGracz, Timer timerAtakGracz, Timer timerMob, Timer timerAtakMob, Timer timerStatystyki, Label labelHpGracz, Label labelManaGracz, Label labelLvGracz, Label labelExpGracz)
        {
            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
            Statystyki formaStatystyki = new Statystyki(daneLauncher);
            //Ekwipunek formaEkwipunek = new Ekwipunek(daneLauncher); // - BUG
            GameOver formaGameOver = new GameOver(daneLauncher, forma);
            labelHpGracz.Text = Convert.ToString("PŻ: " + daneLauncher.daneGracz.hp + "/" + daneLauncher.daneGracz.hpMax);
            labelManaGracz.Text = Convert.ToString("Mana: " + daneLauncher.daneGracz.mana + "/" + daneLauncher.daneGracz.manaMax);
            labelLvGracz.Text = Convert.ToString("Poziom: " + daneLauncher.daneGracz.lv);
            labelExpGracz.Text = Convert.ToString("Dosw: " + daneLauncher.daneGracz.exp + "/" + daneLauncher.daneGracz.expMax);

            metodaUniwersalne.levelUp();
            if (daneLauncher.daneGracz.statystykiDoRozdania > 0)
            {
                daneLauncher.rozdajStatystyki.Visible = true;
            }
            else
            {
                daneLauncher.rozdajStatystyki.Visible = false;
            }
            Tuple<bool, int> czyMobZabity = metodaUniwersalne.śmierćMoba();
            if (czyMobZabity.Item1 == true)
            {
                daneLauncher.daneMob[czyMobZabity.Item2].exists = false;
            }
            if (metodaUniwersalne.śmierćGracza() == true)
            {
                daneLauncher.daneGracz.exists = false;
                daneLauncher.music.SoundLocation = "GameOver.wav";
                daneLauncher.music.Play();
                formaGameOver.Show();
                timerGracz.Enabled = timerAtakGracz.Enabled = timerMob.Enabled = timerAtakMob.Enabled = timerStatystyki.Enabled = false;
            }
            if (metodaUniwersalne.CheckOpened(formaStatystyki.Name) /*| metodaUniwersalne.CheckOpened(formaEkwipunek.Name)*/)
            {
                daneLauncher.daneGracz.up = daneLauncher.daneGracz.down = daneLauncher.daneGracz.left = daneLauncher.daneGracz.right = daneLauncher.daneGracz.zmianaKierunkuUp = daneLauncher.daneGracz.zmianaKierunkuDown = daneLauncher.daneGracz.zmianaKierunkuLeft = daneLauncher.daneGracz.zmianaKierunkuRight = false;
                timerGracz.Enabled = timerAtakGracz.Enabled = timerMob.Enabled = timerAtakMob.Enabled = timerStatystyki.Enabled = false;
            }
            else
            {
                if (daneLauncher.daneGracz.exists == true)
                {
                    if (daneLauncher.daneGracz.wykonanoAtak == false) timerGracz.Enabled = true;
                    if (daneLauncher.daneMob[0].wykonanoAtak == false) timerMob.Enabled = true;
                    timerAtakGracz.Enabled = timerAtakMob.Enabled = true;
                }
            }
        }
        internal void timerStrzałaGraczMetoda(int ilośćMobow,int ilośćPrzeszkod,int ilośćŚcian, int indeksPierwszejŚciany)
        {
            Gracz metodaGracz = new Gracz(daneLauncher);
            metodaGracz.StrzalaGracz(ilośćMobow,ilośćPrzeszkod,ilośćŚcian,indeksPierwszejŚciany);
        }
    }
}
