using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unstable
{
    class Walka
    {
        Launcher daneLauncher;

        public Walka(Launcher dane)
        {
            daneLauncher = dane;
        }

        internal void dmgZwarcieGracz1()
        {
            double dmg = 0;

            dmg += 1 + daneLauncher.daneBonusyGracz.dmgZwarcie[0] + daneLauncher.daneGracz.siła * 0.8;

            daneLauncher.daneGracz.siłaAtakuZwarcie[0] = (int)dmg;
        }
        internal void dmgZwarcieGracz2()
        {
            int dmg = 0;

            dmg += 2 + daneLauncher.daneBonusyGracz.dmgZwarcie[1] + daneLauncher.daneGracz.siła;

            daneLauncher.daneGracz.siłaAtakuZwarcie[1] = dmg;
        }

        internal void dmgDystansGracz1()
        {
            double dmg = 0;

            dmg += 1 + daneLauncher.daneGracz.zręczność * 0.8;

            daneLauncher.daneGracz.siłaAtakuDystans[0] = (int)dmg;
        }
        internal void dmgDystansGracz2()
        {
            int dmg = 0;

            dmg += 2 + daneLauncher.daneGracz.zręczność;

            daneLauncher.daneGracz.siłaAtakuDystans[1] = dmg;
        }

        internal int dmgZwarcieMob(int wartośćAtaku)
        {
            return wartośćAtaku;
        }


        /// <summary>
        /// Metoda sprawdzająca, czy strzała trafiła jakiś obiekt. Jeżeli tak, wykonuje okresloną czynność.
        /// </summary>
        /// <param name="obiekt">W jaki obiekt ma trafić strzała</param>
        /// <param name="ilosc">Ilość możliwych obiektów (maks. idenks)</param>
        internal void strzałaTrafienie(Launcher.ZmiennePostaci[] obiekt, int ilosc)
        {
            for (int i = 0; i < ilosc; i++)
            {
                if (obiekt[i].exists == true)
                {
                    if (daneLauncher.daneStrzała[0].obraz.Bounds.IntersectsWith(obiekt[i].obraz.Bounds))
                    {
                        if (obiekt[i].exists == true)
                        {
                            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
                            daneLauncher.daneStrzała[0].exists = false;
                            daneLauncher.daneStrzała[0].obraz.Visible = false;
                            int dmg = metodaUniwersalne.losuj(daneLauncher.daneGracz.siłaAtakuDystans[0], daneLauncher.daneGracz.siłaAtakuDystans[1]);
                            obiekt[i].hp -= dmg;
                            daneLauncher.hitLog.Text = ("Mopfen zadaje " + dmg + " obrażeń.\n" + daneLauncher.hitLog.Text);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Metoda sprawdzająca, czy strzała trafiła jakiś obiekt. Jeżeli tak, wykonuje okresloną czynność.
        /// </summary>
        /// <param name="obiekt">W jaki obiekt ma trafić strzała</param>
        /// <param name="ilosc">Ilość możliwych obiektów (maks. idenks)</param>
        internal void strzałaTrafienie(Launcher.ZmienneObiektów[] obiekt, int pierwszyIndeks, int ilosc)
        {
            for (int i = pierwszyIndeks; i < ilosc + pierwszyIndeks; i++)
            {
                if (obiekt[i].exists == true)
                {
                    if (daneLauncher.daneStrzała[0].obraz.Bounds.IntersectsWith(obiekt[i].obraz.Bounds))
                    {
                        if (obiekt[i].exists == true)
                        {
                            daneLauncher.daneStrzała[0].exists = false;
                            daneLauncher.daneStrzała[0].obraz.Visible = false;
                            obiekt[i].exists = false;
                            obiekt[i].obraz.Visible = false;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Metoda sprawdza, czy gracz zginął
        /// </summary>
        /// <returns></returns>
        internal bool śmierćGracza()
        {
            if (daneLauncher.daneGracz.hp <= 0)
            {
                daneLauncher.daneGracz.hp = 0;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Metoda sprawdza, czy mob został zabity. Jeśli tak, to wykonuje ustalone operacje
        /// </summary>
        /// <returns></returns>
        internal Tuple<bool, int> śmierćMoba()
        {
            int i = 0;
            bool zabity = false;
            Tuple<bool, int> wynik = new Tuple<bool, int>(zabity, i);
            for (i = 0; i < 4; i++)
            {
                if (daneLauncher.daneMob[i].exists == true)
                {
                    if (daneLauncher.daneMob[i].hp <= 0)
                    {
                        daneLauncher.daneMob[i].hp = 0;
                        zabity = true;
                        daneLauncher.hitLog.Text = "Mob zostaje zabity!\n" + daneLauncher.hitLog.Text;
                        if (daneLauncher.daneGracz.lv == daneLauncher.daneMob[i].lv) daneLauncher.daneGracz.exp += 5;
                        daneLauncher.daneMob[i].obraz.Visible = false;
                        daneLauncher.daneMob[i].labelhp.Visible = false;
                        wynik = new Tuple<bool, int>(zabity, i);
                        return wynik;
                    }
                }
            }
            return wynik;
        }
        /// <summary>
        /// Metoda sprawdza czy obok gracza znajduje się jakiś obiekt. Jeżeli tak, to wykonuje atak.
        /// </summary>
        /// <param name="obiekt">Obiekt, w który kierowany jest atak</param>
        /// <param name="ilosc">Ilość możliwych obiektów (maks. idenks)</param>
        internal void atakwCelObok(Launcher.ZmiennePostaci[] obiekt, int ilosc)
        {
            for (int i = 0; i < ilosc; i++)
            {
                if (obiekt[i].exists == true)
                {
                    if ((daneLauncher.daneGracz.left == true & (daneLauncher.daneGracz.obraz.Left - obiekt[i].obraz.Left >= (60) & daneLauncher.daneGracz.obraz.Left - obiekt[i].obraz.Right < 8 & (obiekt[i].obraz.Top - daneLauncher.daneGracz.obraz.Top >= (-64) & obiekt[i].obraz.Top - daneLauncher.daneGracz.obraz.Top < daneLauncher.daneGracz.obraz.Height)) |
                     (daneLauncher.daneGracz.right == true & (obiekt[i].obraz.Left - daneLauncher.daneGracz.obraz.Left >= (-60) & obiekt[i].obraz.Left - daneLauncher.daneGracz.obraz.Right < 8 & (obiekt[i].obraz.Top - daneLauncher.daneGracz.obraz.Top >= (-64) & obiekt[i].obraz.Top - daneLauncher.daneGracz.obraz.Top < daneLauncher.daneGracz.obraz.Height)))))
                    {
                        Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
                        dmgZwarcieGracz1();
                        dmgZwarcieGracz2();
                        int dmg = metodaUniwersalne.losuj(daneLauncher.daneGracz.siłaAtakuZwarcie[0], daneLauncher.daneGracz.siłaAtakuZwarcie[1]);
<<<<<<< HEAD
                        if (metodaUniwersalne.losuj(0, 100) <= daneLauncher.daneGracz.szansaKryta)
                        {
                            dmg *= 2;
                            daneLauncher.hitLog.Text = ("Mopfen zadaje " + dmg + " obrażeń krytycznych.\n" + daneLauncher.hitLog.Text);
=======
                        int dmgK = dmg * 2;
                        if (metodaUniwersalne.losuj(0, 100) <= daneLauncher.daneGracz.szansaKryta)
                        {
                            daneLauncher.hitLog.Text = ("Mopfen zadaje " + dmgK + " obrażeń krytycznych.\n" + daneLauncher.hitLog.Text);
>>>>>>> refs/remotes/origin/Unstable1.1
                        }
                        else
                        {
                            daneLauncher.hitLog.Text = ("Mopfen zadaje " + dmg + " obrażeń.\n" + daneLauncher.hitLog.Text);
                        }
                        obiekt[i].hp -= dmg;
                    }

                }
            }
        }
        /// <summary>
        /// Metoda sprawdza czy obok gracza znajduje się jakiś obiekt. Jeżeli tak, to wykonuje atak.
        /// </summary>
        /// <param name="obiekt">Obiekt, w który kierowany jest atak</param>
        /// <param name="ilosc">Ilość możliwych obiektów (maks. idenks)</param>
        internal void atakwCelObok(Launcher.ZmienneObiektów[] obiekt, int indeksMin, int indeksMax)
        {
            for (int i = indeksMin; i <= indeksMax; i++)
            {
                if (obiekt[i].exists == true)
                {
                    if ((daneLauncher.daneGracz.left == true & (daneLauncher.daneGracz.obraz.Left - obiekt[i].obraz.Left >= (60) & daneLauncher.daneGracz.obraz.Left - obiekt[i].obraz.Right < 8 & (obiekt[i].obraz.Top - daneLauncher.daneGracz.obraz.Top >= (-64) & obiekt[i].obraz.Top - daneLauncher.daneGracz.obraz.Top < daneLauncher.daneGracz.obraz.Height)) |
                     (daneLauncher.daneGracz.right == true & (obiekt[i].obraz.Left - daneLauncher.daneGracz.obraz.Left >= (-60) & obiekt[i].obraz.Left - daneLauncher.daneGracz.obraz.Right < 8 & (obiekt[i].obraz.Top - daneLauncher.daneGracz.obraz.Top >= (-64) & obiekt[i].obraz.Top - daneLauncher.daneGracz.obraz.Top < daneLauncher.daneGracz.obraz.Height)))))
                    {
                        obiekt[i].exists = false;
                        obiekt[i].obraz.Visible = false;
                    }
                }
            }
        }

        /// <summary> Metoda odpowiedzialna za wykonywanie ataku przez gracza.</summary>
        public void AtakGracza(Timer timerGracz)
        {
            if (daneLauncher.daneGracz.attack == true & (daneLauncher.daneGracz.left == true | daneLauncher.daneGracz.right == true) & daneLauncher.daneGracz.wykonanoAtak == false)
            {
                if (daneLauncher.daneGracz.rodzajAtaku == true & daneLauncher.daneGracz.posiadaMiecz == true)
                {
                    if (daneLauncher.daneGracz.left == true) daneLauncher.daneGracz.obraz.Image = daneLauncher.whiteBrownAttackingLeft.Image;
                    if (daneLauncher.daneGracz.right == true) daneLauncher.daneGracz.obraz.Image = daneLauncher.whiteBrownAttackingRight.Image;
                    atakwCelObok(daneLauncher.daneMob, 5);

                    #region metodaUniwersalne.atakwCelObok(daneLauncher.danePrzeszkoda,...)
                    if (daneLauncher.daneMapa[1].gdzieOstatnio == 0) atakwCelObok(daneLauncher.danePrzeszkoda, 0, 8);
                    if (daneLauncher.daneMapa[1].gdzieOstatnio == 1) atakwCelObok(daneLauncher.danePrzeszkoda, 12, 12);

                    #endregion
                }
                if (daneLauncher.daneGracz.rodzajAtaku == false & daneLauncher.daneGracz.posiadaŁuk == true)
                {
                    if (daneLauncher.daneStrzała[0].exists == false)
                    {
                        if (daneLauncher.daneGracz.left == true)
                        {
                            daneLauncher.daneGracz.obraz.Image = daneLauncher.whiteBrownShotingLeft.Image;
                            daneLauncher.daneStrzała[0].exists = true;
                            daneLauncher.daneStrzała[0].obraz.Image = daneLauncher.strzałaLeft.Image;
                            daneLauncher.daneStrzała[0].obraz.Left = (daneLauncher.daneGracz.obraz.Left - daneLauncher.daneStrzała[0].obraz.Width);
                            daneLauncher.daneStrzała[0].obraz.Top = (daneLauncher.daneGracz.obraz.Top + daneLauncher.daneGracz.obraz.Height / 2);
                        }
                        if (daneLauncher.daneGracz.right == true)
                        {
                            daneLauncher.daneGracz.obraz.Image = daneLauncher.whiteBrownShotingRight.Image;
                            daneLauncher.daneStrzała[0].exists = true;
                            daneLauncher.daneStrzała[0].obraz.Image = daneLauncher.strzałaRight.Image;
                            daneLauncher.daneStrzała[0].obraz.Left = (daneLauncher.daneGracz.obraz.Right);
                            daneLauncher.daneStrzała[0].obraz.Top = (daneLauncher.daneGracz.obraz.Top + daneLauncher.daneGracz.obraz.Height / 2);
                        }
                        daneLauncher.daneGracz.stopMoving = -5;
                    }
                }

                daneLauncher.daneGracz.zmianaKierunkuLeft = daneLauncher.daneGracz.zmianaKierunkuRight = false;
                daneLauncher.daneGracz.wykonanoAtak = true;
            }
            if (daneLauncher.daneGracz.wykonanoAtak == true) { timerGracz.Enabled = false; daneLauncher.daneGracz.stopMoving++; }
            if (daneLauncher.daneGracz.stopMoving == 5)
            {
                timerGracz.Enabled = true;
                daneLauncher.daneGracz.wykonanoAtak = false;
                daneLauncher.daneGracz.stopMoving = 0;
            }
            daneLauncher.daneGracz.attack = false;
        }
        /// <summary>
        /// Metoda opowiedzialna za strzał z łuku gracz
        /// </summary>
        public void StrzalaGracz(int ilośćMobow, int ilośćPrzeszkod, int indeksPierwszejPrzeszkody, int ilośćŚcian, int indeksPierwszejŚciany)
        {
            bool stop = false; // zmienna określa, kiedy strzała w coś trafi
            for (int i = indeksPierwszejŚciany; i < ilośćŚcian + indeksPierwszejŚciany; i++)
            {
                if (daneLauncher.danePrzeszkoda[i].exists == true)
                {
                    if (daneLauncher.daneStrzała[0].obraz.Bounds.IntersectsWith(daneLauncher.danePrzeszkoda[i].obraz.Bounds)) stop = true;
                }
            }
            if (daneLauncher.daneStrzała[0].exists == true & daneLauncher.daneGracz.stopMoving >= 0)
            {
                daneLauncher.daneStrzała[0].obraz.Visible = true;
                strzałaTrafienie(daneLauncher.daneMob, ilośćMobow);
                strzałaTrafienie(daneLauncher.danePrzeszkoda, indeksPierwszejPrzeszkody, ilośćPrzeszkod);
                if (daneLauncher.daneStrzała[0].obraz.Image == daneLauncher.strzałaLeft.Image)
                {
                    if (daneLauncher.daneStrzała[0].obraz.Left > daneLauncher.poleGry.Left & stop == false)
                    {
                        daneLauncher.daneStrzała[0].obraz.Left -= 8;
                    }
                    else
                    {
                        daneLauncher.daneStrzała[0].exists = false;
                        daneLauncher.daneStrzała[0].obraz.Visible = false;
                    }
                }
                if (daneLauncher.daneStrzała[0].obraz.Image == daneLauncher.strzałaRight.Image)
                {
                    if (daneLauncher.daneStrzała[0].obraz.Right < daneLauncher.poleGry.Right & stop == false)
                    {
                        daneLauncher.daneStrzała[0].obraz.Left += 8;
                    }
                    else
                    {
                        daneLauncher.daneStrzała[0].exists = false;
                        daneLauncher.daneStrzała[0].obraz.Visible = false;
                    }
                }
            }
        }
    }
}
