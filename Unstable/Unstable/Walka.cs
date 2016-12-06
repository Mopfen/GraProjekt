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

        /// <summary>
        /// Metoda oblicza minimalną wartość ataku gracza w zwarciu
        /// </summary>
        internal void dmgZwarcie()
        {
            double dmgMin = 0;
            double dmgMax = 0;

            dmgMin += 1 + daneLauncher.daneBonusyGracz.dmgZwarcie[0] + daneLauncher.daneGracz.siła * 0.8;
            dmgMax += 2 + daneLauncher.daneBonusyGracz.dmgZwarcie[1] + daneLauncher.daneGracz.siła;

            daneLauncher.daneGracz.siłaAtakuZwarcie[0] = (int)dmgMin;
            daneLauncher.daneGracz.siłaAtakuZwarcie[1] = (int)dmgMax;
        }
        /// <summary>
        /// Metoda przypisuje minimalną wartośc ataku moba w zwarciu
        /// </summary>
        /// <param name="postać">Okresla postać, której ma zostac przypisana wartość ataku</param>
        /// <param name="indeks">Określa indeks postaci, której ma zostać przypisana wartość ataku</param>
        /// <param name="dmgMin">Określa wartość minimalnej wartości ataku, która ma zostać prypisana postaci</param>
        /// <param name="dmgMax">Określa wartość maksymalnej wartości ataku, która ma zostać prypisana postaci</param>
        internal void dmgZwarcie(Launcher.ZmiennePostaci[] postać, int indeks, int dmgMin, int dmgMax)
        {
            postać[indeks].siłaAtakuZwarcie[0] = dmgMin;
            postać[indeks].siłaAtakuZwarcie[1] = dmgMax;
        }

        /// <summary>
        /// Metoda oblicza minimalną wartość ataku gracza na dystans
        /// </summary>
        internal void dmgDystans()
        {
            double dmgMin = 0;
            double dmgMax = 0;

            dmgMin += 1 + daneLauncher.daneBonusyGracz.dmgDystans[0] + daneLauncher.daneGracz.zręczność * 0.8;
            dmgMax += 2 + daneLauncher.daneBonusyGracz.dmgDystans[1] + daneLauncher.daneGracz.zręczność;

            daneLauncher.daneGracz.siłaAtakuDystans[0] = (int)dmgMin;
            daneLauncher.daneGracz.siłaAtakuDystans[1] = (int)dmgMax;
        }
        /// <summary>
        /// Metoda przypisuje minimalną wartośc ataku moba na dystans
        /// </summary>
        /// <param name="postać">Okresla postać, której ma zostac przypisana wartość ataku</param>
        /// <param name="indeks">Określa indeks postaci, której ma zostać przypisana wartość ataku</param>
        /// <param name="dmgMin">Określa wartość minimalnej wartości ataku, która ma zostać prypisana postaci</param>
        /// <param name="dmgMax">Określa wartość maksymalnej wartości ataku, która ma zostać prypisana postaci</param>
        internal void dmgDystans(Launcher.ZmiennePostaci[] postać, int indeks, int dmgMin, int dmgMax)
        {
            postać[indeks].siłaAtakuDystans[0] = dmgMin;
            postać[indeks].siłaAtakuDystans[1] = dmgMax;
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
                            int dmgK = dmg * 2;
                            if (metodaUniwersalne.losuj(0, 100) <= daneLauncher.daneGracz.szansaKryta)
                            {
                                daneLauncher.hitLog.Text = ("Mopfen zadaje " + dmgK + " obrażeń krytycznych.\n" + daneLauncher.hitLog.Text);
                                obiekt[i].hp -= dmgK;
                            }
                            else
                            {
                                daneLauncher.hitLog.Text = ("Mopfen zadaje " + dmg + " obrażeń.\n" + daneLauncher.hitLog.Text);
                                obiekt[i].hp -= dmg;
                            }
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
        internal void strzałaTrafienie(List<Launcher.ZmienneObiektów> obiekt, int numerMapy, int numerLokacji)
        {
            foreach (var indeks in obiekt.Where(x => x.numerMapy == numerMapy & x.numerLokacji == numerLokacji & x.exists == true))
            {
                if (daneLauncher.daneStrzała[0].obraz.Bounds.IntersectsWith(obiekt[obiekt.IndexOf(indeks)].obraz.Bounds))
                {
                    Muzyka metodaMuzyka = new Muzyka(daneLauncher);
                   
                    daneLauncher.daneStrzała[0].exists = false;
                    daneLauncher.daneStrzała[0].obraz.Visible = false;
                    if (obiekt[obiekt.IndexOf(indeks)].ściana == false)
                    {
                        obiekt[obiekt.IndexOf(indeks)].exists = false;
                        obiekt[obiekt.IndexOf(indeks)].obraz.Visible = false;
                        metodaMuzyka.SoundEffect(daneLauncher.soundInterface, "NiszczonyObiekt.wav");
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
                        dmgZwarcie();
                        int dmg = metodaUniwersalne.losuj(daneLauncher.daneGracz.siłaAtakuZwarcie[0], daneLauncher.daneGracz.siłaAtakuZwarcie[1]);
                        int dmgK = dmg * 2;
                        if (metodaUniwersalne.losuj(1, 100) <= daneLauncher.daneGracz.szansaKryta)
                        {
                            daneLauncher.hitLog.Text = ("Mopfen zadaje " + dmgK + " obrażeń krytycznych.\n" + daneLauncher.hitLog.Text);
                            obiekt[i].hp -= dmgK;
                        }
                        else
                        {
                            daneLauncher.hitLog.Text = ("Mopfen zadaje " + dmg + " obrażeń.\n" + daneLauncher.hitLog.Text);
                            obiekt[i].hp -= dmg;
                        }
                    }

                }
            }
        }
        /// <summary>
        /// Metoda sprawdza czy obok gracza znajduje się jakiś obiekt. Jeżeli tak, to wykonuje atak.
        /// </summary>
        /// <param name="obiekt">Obiekt, w który kierowany jest atak</param>
        /// <param name="ilosc">Ilość możliwych obiektów (maks. idenks)</param>
        internal void atakwCelObok(List<Launcher.ZmienneObiektów> obiekt, int numerMapy, int numerLokacji)
        {
            foreach (var indeks in obiekt.Where(x => x.numerMapy == numerMapy & x.numerLokacji == numerLokacji & x.exists == true & x.ściana == false))
            {
                if ((daneLauncher.daneGracz.left == true & (daneLauncher.daneGracz.obraz.Left - obiekt[obiekt.IndexOf(indeks)].obraz.Left >= (60) & daneLauncher.daneGracz.obraz.Left - obiekt[obiekt.IndexOf(indeks)].obraz.Right < 8 & (obiekt[obiekt.IndexOf(indeks)].obraz.Top - daneLauncher.daneGracz.obraz.Top >= (-64) & obiekt[obiekt.IndexOf(indeks)].obraz.Top - daneLauncher.daneGracz.obraz.Top < daneLauncher.daneGracz.obraz.Height)) |
                (daneLauncher.daneGracz.right == true & (obiekt[obiekt.IndexOf(indeks)].obraz.Left - daneLauncher.daneGracz.obraz.Left >= (-60) & obiekt[obiekt.IndexOf(indeks)].obraz.Left - daneLauncher.daneGracz.obraz.Right < 8 & (obiekt[obiekt.IndexOf(indeks)].obraz.Top - daneLauncher.daneGracz.obraz.Top >= (-64) & obiekt[obiekt.IndexOf(indeks)].obraz.Top - daneLauncher.daneGracz.obraz.Top < daneLauncher.daneGracz.obraz.Height)))))
                {
                    Muzyka metodaMuzyka = new Muzyka(daneLauncher);

                    metodaMuzyka.SoundEffect(daneLauncher.soundInterface, "NiszczonyObiekt.wav");
                    

                    obiekt[obiekt.IndexOf(indeks)].exists = false;
                    obiekt[obiekt.IndexOf(indeks)].obraz.Visible = false;
                }
            }        
        }

        /// <summary>
        /// Metoda odpowiedzialna za wykonywanie ataku przez gracza.
        /// </summary>
        public void AtakGracza(Timer timerGracz, int numerMapy, int numerLokacji)
        {
            if (daneLauncher.daneGracz.attack == true & (daneLauncher.daneGracz.left == true | daneLauncher.daneGracz.right == true) & daneLauncher.daneGracz.wykonanoAtak == false)
            {
                if (daneLauncher.daneGracz.rodzajAtaku == true & daneLauncher.daneGracz.posiadaMiecz == true)
                {
                    Muzyka metodaMuzyka = new Muzyka(daneLauncher);

                    if (daneLauncher.daneGracz.left == true) daneLauncher.daneGracz.obraz.Image = daneLauncher.whiteBrownAttackingLeft.Image;
                    if (daneLauncher.daneGracz.right == true) daneLauncher.daneGracz.obraz.Image = daneLauncher.whiteBrownAttackingRight.Image;
                    metodaMuzyka.SoundEffect(daneLauncher.soundGracz, "MachnięcieMieczem.wav");
                    atakwCelObok(daneLauncher.daneMob, 5);
                    atakwCelObok(daneLauncher.danePrzeszkoda, numerMapy, numerLokacji);

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
            if (daneLauncher.daneGracz.wykonanoAtak == true)
            {
                timerGracz.Enabled = false;
                daneLauncher.daneGracz.stopMoving++;
            }
            if (daneLauncher.daneGracz.stopMoving == 5)
            {
                timerGracz.Enabled = true;
                daneLauncher.daneGracz.wykonanoAtak = false;
                daneLauncher.daneGracz.stopMoving = 0;
            }
            if (daneLauncher.daneGracz.stopMoving == 1 & (daneLauncher.daneGracz.obraz.Image == daneLauncher.whiteBrownShotingLeft.Image | daneLauncher.daneGracz.obraz.Image == daneLauncher.whiteBrownShotingRight.Image))
            {
                Muzyka metodaMuzyka = new Muzyka(daneLauncher);
                metodaMuzyka.SoundEffect(daneLauncher.soundGracz, "ŁukStrzał.mp3");
            }
            daneLauncher.daneGracz.attack = false;
        }
        /// <summary>
        /// Metoda opowiedzialna za strzał z łuku gracz
        /// </summary>
        public void StrzalaGracz(int ilośćMobow, int numerMapy, int numerLokacji)
        {
            bool stop = false; // zmienna określa, kiedy strzała w coś trafi
            
            if (daneLauncher.daneStrzała[0].exists == true & daneLauncher.daneGracz.stopMoving >= 0)
            {
                daneLauncher.daneStrzała[0].obraz.Visible = true;
                strzałaTrafienie(daneLauncher.daneMob, ilośćMobow);
                strzałaTrafienie(daneLauncher.danePrzeszkoda, numerMapy, numerLokacji);
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

        /// <summary>
        /// Metoda odpowiedzialna za wykonywanie ataku przez Moba.
        /// </summary>
        public void AtakMoba(Timer timerMob, int numerMoba, int wartośćAtakuMin, int wartośćAtakuMax)
        {
            Uniwersalne metodaUniwersalne = new Uniwersalne(daneLauncher);
            Walka metodaWalka = new Walka(daneLauncher);
            if (daneLauncher.daneMob[numerMoba].exists == true)
            {
                if (daneLauncher.daneMob[numerMoba].stopMoving == 0 & daneLauncher.daneMob[numerMoba].attack == false & (daneLauncher.daneMob[numerMoba].obraz.Left - daneLauncher.daneGracz.obraz.Right >= (-16) & daneLauncher.daneMob[numerMoba].obraz.Left - daneLauncher.daneGracz.obraz.Right < 8 & daneLauncher.daneGracz.obraz.Top - daneLauncher.daneMob[numerMoba].obraz.Top >= (-64) & daneLauncher.daneGracz.obraz.Top - daneLauncher.daneMob[numerMoba].obraz.Top < daneLauncher.daneMob[numerMoba].obraz.Height))
                {
                    daneLauncher.daneMob[numerMoba].obraz.Image = daneLauncher.whiteBrownAttackingLeft.Image;
                    daneLauncher.daneMob[numerMoba].attack = true;
                }
                if (daneLauncher.daneMob[numerMoba].stopMoving == 0 & daneLauncher.daneMob[numerMoba].attack == false & (daneLauncher.daneGracz.obraz.Left - daneLauncher.daneMob[numerMoba].obraz.Right >= (-16) & daneLauncher.daneGracz.obraz.Left - daneLauncher.daneMob[numerMoba].obraz.Right < 8 & daneLauncher.daneGracz.obraz.Top - daneLauncher.daneMob[numerMoba].obraz.Top >= (-64) & daneLauncher.daneGracz.obraz.Top - daneLauncher.daneMob[numerMoba].obraz.Top < daneLauncher.daneMob[numerMoba].obraz.Height))
                {
                    daneLauncher.daneMob[numerMoba].obraz.Image = daneLauncher.whiteBrownAttackingRight.Image;
                    daneLauncher.daneMob[numerMoba].attack = true;
                    daneLauncher.daneMob[numerMoba].up = daneLauncher.daneMob[numerMoba].down = daneLauncher.daneMob[numerMoba].left = daneLauncher.daneMob[numerMoba].right = daneLauncher.daneMob[numerMoba].zmianaKierunkuUp = daneLauncher.daneMob[numerMoba].zmianaKierunkuDown = daneLauncher.daneMob[numerMoba].zmianaKierunkuLeft = daneLauncher.daneMob[numerMoba].zmianaKierunkuRight = false;
                }
                if (daneLauncher.daneMob[numerMoba].stopMoving == 0 & daneLauncher.daneMob[numerMoba].attack == true)
                {
                    metodaWalka.dmgZwarcie(daneLauncher.daneMob, numerMoba, wartośćAtakuMin, wartośćAtakuMax);
                    int dmg = metodaUniwersalne.losuj(daneLauncher.daneMob[numerMoba].siłaAtakuZwarcie[0], daneLauncher.daneMob[numerMoba].siłaAtakuZwarcie[1]);
                    int dmgK = dmg * 2;
                    if (metodaUniwersalne.losuj(1, 100) <= daneLauncher.daneMob[numerMoba].szansaKryta)
                    {
                        daneLauncher.hitLog.Text = ("Mob zadaje " + dmgK + " obrażeń krytycznych.\n" + daneLauncher.hitLog.Text);
                        daneLauncher.daneGracz.hp -= dmgK;
                    }
                    else
                    {
                        daneLauncher.hitLog.Text = ("Mob zadaje " + dmg + " obrażeń.\n" + daneLauncher.hitLog.Text);
                        daneLauncher.daneGracz.hp -= dmg;
                    }
                    daneLauncher.daneMob[numerMoba].wykonanoAtak = true;
                    daneLauncher.daneMob[numerMoba].zmianaKierunkuLeft = daneLauncher.daneMob[numerMoba].zmianaKierunkuRight = false;
                }
                if (daneLauncher.daneMob[numerMoba].wykonanoAtak == true) { timerMob.Enabled = false; daneLauncher.daneMob[numerMoba].stopMoving++; }
                if (daneLauncher.daneMob[numerMoba].stopMoving == 5)
                {
                    timerMob.Enabled = true;
                    daneLauncher.daneMob[numerMoba].wykonanoAtak = false;
                    daneLauncher.daneMob[numerMoba].stopMoving = 0;
                }
                daneLauncher.daneMob[numerMoba].attack = false;
            }
        }
    }
}
