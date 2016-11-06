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
            if (e.KeyCode == Keys.Up) { daneLauncher.daneGracz[0].up = true; }
            if (e.KeyCode == Keys.Down) { daneLauncher.daneGracz[0].down = true; }
            if (e.KeyCode == Keys.Left) { daneLauncher.daneGracz[0].left = true; }
            if (e.KeyCode == Keys.Right) { daneLauncher.daneGracz[0].right = true; }
            if (e.KeyCode == Keys.Space) daneLauncher.daneGracz[0].attack = true;
            if (e.KeyCode == Keys.Escape)
            {
                MenuGlowne formaMenuGlowne = new MenuGlowne(daneLauncher);

                forma.Close();
                formaMenuGlowne.Show();
            }
            if (e.KeyCode == Keys.C)
            {
                Statystyki formaStatystyki = new Statystyki(daneLauncher);
                formaStatystyki.ShowDialog();
            }
            if (e.KeyCode == Keys.X)
            {
                if (daneLauncher.daneGracz[0].rodzajAtaku == true) daneLauncher.daneGracz[0].rodzajAtaku = false;
                else daneLauncher.daneGracz[0].rodzajAtaku = true;
            }
        }
        /// <summary>
        /// Metoda wykonująca czynności po puszczeniu ustalonych klawiszy
        /// </summary>
        internal void KeyUpMetoda(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) { daneLauncher.daneGracz[0].up = false; daneLauncher.daneGracz[0].zmianaKierunkuUp = false; }
            if (e.KeyCode == Keys.Down) { daneLauncher.daneGracz[0].down = false; daneLauncher.daneGracz[0].zmianaKierunkuDown = false; }
            if (e.KeyCode == Keys.Left) { daneLauncher.daneGracz[0].left = false; daneLauncher.daneGracz[0].zmianaKierunkuLeft = false; }
            if (e.KeyCode == Keys.Right) { daneLauncher.daneGracz[0].right = false; daneLauncher.daneGracz[0].zmianaKierunkuRight = false; }
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
            GameOver formaGameOver = new GameOver(daneLauncher, forma);
            labelHpGracz.Text = Convert.ToString("PŻ: " + daneLauncher.daneGracz[0].hp + "/" + daneLauncher.daneGracz[0].hpMax);
            labelManaGracz.Text = Convert.ToString("Mana: " + daneLauncher.daneGracz[0].mana + "/" + daneLauncher.daneGracz[0].manaMax);
            labelLvGracz.Text = Convert.ToString("Poziom: " + daneLauncher.daneGracz[0].lv);
            labelExpGracz.Text = Convert.ToString("Dosw: " + daneLauncher.daneGracz[0].exp + "/" + daneLauncher.daneGracz[0].expMax);

            if (metodaUniwersalne.levelUp() == true)
            {

            }
            Tuple<bool, int> czyMobZabity = metodaUniwersalne.śmierćMoba();
            if (czyMobZabity.Item1 == true)
            {
                daneLauncher.daneMob[czyMobZabity.Item2].alive = false;
            }
            if (metodaUniwersalne.śmierćGracza() == true)
            {
                daneLauncher.daneGracz[0].alive = false;
                daneLauncher.music.SoundLocation = "GameOver.wav";
                daneLauncher.music.Play();
                formaGameOver.Show();
                timerGracz.Enabled = timerAtakGracz.Enabled = timerMob.Enabled = timerAtakMob.Enabled = timerStatystyki.Enabled = false;
            }
            if (metodaUniwersalne.CheckOpened(formaStatystyki.Name))
            {
                daneLauncher.daneGracz[0].up = daneLauncher.daneGracz[0].down = daneLauncher.daneGracz[0].left = daneLauncher.daneGracz[0].right = daneLauncher.daneGracz[0].zmianaKierunkuUp = daneLauncher.daneGracz[0].zmianaKierunkuDown = daneLauncher.daneGracz[0].zmianaKierunkuLeft = daneLauncher.daneGracz[0].zmianaKierunkuRight = false;
                timerGracz.Enabled = timerAtakGracz.Enabled = timerMob.Enabled = timerAtakMob.Enabled = false;
            }
            else
            {
                if (daneLauncher.daneGracz[0].alive == true)
                {
                    if (daneLauncher.daneGracz[0].wykonanoAtak == false) timerGracz.Enabled = true;
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
