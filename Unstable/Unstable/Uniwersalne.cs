using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.Linq.Expressions;

namespace Unstable
{
    /// <summary> Zawiera uniwersalne metody, których można użyć w całym programie.</summary>
    class Uniwersalne
    {
        /// <summary> Umożliwia dostęp do danych zawartych w klasie Launcher.</summary>
        Launcher daneLauncher;

        public Uniwersalne(Launcher dane)
        {
            daneLauncher = dane;
        }

        #region walka
        internal void dmgZwarcieGracz1() 
        {
            double dmg = 0;

            dmg += 1 + daneLauncher.daneBonusyGracz.dmgZwarcie[0] + daneLauncher.daneGracz.siła *0.8;

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

        internal void hpMaxGracz()
        {
            daneLauncher.daneGracz.hpMax = (10 + daneLauncher.daneGracz.lv * 10 + daneLauncher.daneGracz.wytrzymałość * 5);
        }
        internal void manaMaxGracz()
        {
            daneLauncher.daneGracz.manaMax = (daneLauncher.daneGracz.lv * 10 + daneLauncher.daneGracz.inteligencja * 5);
        }
        internal void szansaKrytykGracz()
        {
            daneLauncher.daneGracz.szansaKryta = Convert.ToInt16(((daneLauncher.daneGracz.szczęście * 10) / daneLauncher.daneGracz.lv));
        }

        /// <summary>
        /// Metoda sprawdzająca, czy strzała trafiła jakiś obiekt. Jeżeli tak, wykonuje okresloną czynność.
        /// </summary>
        /// <param name="obiekt">W jaki obiekt ma trafić strzała</param>
        /// <param name="ilosc">Ilość możliwych obiektów (maks. idenks)</param>
        internal void strzałaTrafienie(Launcher.ZmiennePostaci []obiekt, int ilosc)
        {
            for (int i = 0; i < ilosc; i++)
            {
                if (obiekt[i].exists == true)
                {
                    if (daneLauncher.daneStrzała[0].obraz.Bounds.IntersectsWith(obiekt[i].obraz.Bounds))
                    {
                        if (obiekt[i].exists == true)
                        {
                            daneLauncher.daneStrzała[0].exists = false;
                            daneLauncher.daneStrzała[0].obraz.Visible = false;
                            int dmg = losuj(daneLauncher.daneGracz.siłaAtakuDystans[0], daneLauncher.daneGracz.siłaAtakuDystans[1]);
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
        internal void strzałaTrafienie(Launcher.ZmienneObiektów []obiekt, int pierwszyIndeks, int ilosc)
        {
            for (int i = pierwszyIndeks; i < ilosc+pierwszyIndeks; i++)
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
        internal Tuple<bool,int> śmierćMoba()
        {
            int i = 0;
            bool zabity = false;
            Tuple<bool, int> wynik = new Tuple<bool, int>(zabity, i);
            for (i = 0; i < 4; i++)
            {
                if(daneLauncher.daneMob[i].exists==true)
                {
                    if (daneLauncher.daneMob[i].hp <= 0)
                    {
                        daneLauncher.daneMob[i].hp = 0;
                        zabity = true;
                        daneLauncher.hitLog.Text = "Mob zostaje zabity!\n" + daneLauncher.hitLog.Text;
                        if (daneLauncher.daneGracz.lv == daneLauncher.daneMob[i].lv) daneLauncher.daneGracz.exp +=5;
                        daneLauncher.daneMob[i].obraz.Visible=false;
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
        internal void atakwCelObok(Launcher.ZmiennePostaci []obiekt, int ilosc)
        {
            for (int i = 0; i < ilosc; i++)
            {
                if (obiekt[i].exists == true)
                {
                    if ((daneLauncher.daneGracz.left == true & (daneLauncher.daneGracz.obraz.Left - obiekt[i].obraz.Left >= (60) & daneLauncher.daneGracz.obraz.Left - obiekt[i].obraz.Right < 8 & (obiekt[i].obraz.Top - daneLauncher.daneGracz.obraz.Top >= (-64) & obiekt[i].obraz.Top - daneLauncher.daneGracz.obraz.Top < daneLauncher.daneGracz.obraz.Height)) |
                     (daneLauncher.daneGracz.right == true & (obiekt[i].obraz.Left - daneLauncher.daneGracz.obraz.Left >= (-60) & obiekt[i].obraz.Left - daneLauncher.daneGracz.obraz.Right < 8 & (obiekt[i].obraz.Top - daneLauncher.daneGracz.obraz.Top >= (-64) & obiekt[i].obraz.Top - daneLauncher.daneGracz.obraz.Top < daneLauncher.daneGracz.obraz.Height)))))
                    {
                        dmgZwarcieGracz1();
                        dmgZwarcieGracz2();
                        int dmg = losuj(daneLauncher.daneGracz.siłaAtakuZwarcie[0], daneLauncher.daneGracz.siłaAtakuZwarcie[1]);
                        if(losuj(0,100)<=daneLauncher.daneGracz.szansaKryta)
                        {
                            dmg *= 2;
                            daneLauncher.hitLog.Text = ("Mopfen zadaje " + dmg + " obrażeń krytycznych.\n" + daneLauncher.hitLog.Text);
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

        #endregion
        #region poruszanieSię
        /// <summary> Metoda odpowiedzialna za ruch postaci.</summary>
        internal void RuchPostaci(Launcher.ZmiennePostaci postać)
        {
            if (postać.up == true & postać.down != true & postać.obraz.Top > daneLauncher.poleGry.Top + 2 & postać.wykonanoAtak == false & postać.przeszkoda == false)
            {
                postać.obraz.Top -= 4; // ruch w górę
            }
            else
            {
                if (postać.down == true & postać.up != true & postać.obraz.Bottom < daneLauncher.poleGry.Bottom & postać.wykonanoAtak == false & postać.przeszkoda == false)
                {
                    postać.obraz.Top += 4; // ruch w dół
                }
                else
                {
                    if (postać.left == true & postać.right != true & postać.obraz.Left > daneLauncher.poleGry.Left & postać.wykonanoAtak == false & postać.przeszkoda == false)
                    {
                        postać.obraz.Left -= 4; // ruch w lewo
                    }
                    else
                    {
                        if (postać.right == true & postać.left != true & postać.obraz.Right < daneLauncher.poleGry.Right & postać.wykonanoAtak == false & postać.przeszkoda == false)
                        {
                            postać.obraz.Left += 4; // ruch w prawo
                        }
                    }
                }
            }
            postać.przeszkoda = false;
        }
        /// <summary>
        /// Metoda sprawdza, czy na drodze postaci znajduje się przeszkoda. Jeśli tak, nie pozwala jej iść dalej.
        /// </summary>
        /// <param name="idący">Idąca postać</param>
        /// <param name="obiekt">Istniejąca przeszkoda</param>
        internal void przeszkodaNaDrodze(Launcher.ZmiennePostaci idący, Launcher.ZmienneObiektów obiekt)
        {
            if (obiekt.exists == true)
            {
                if (idący.obraz.Bounds.IntersectsWith(obiekt.obraz.Bounds))
                {
                    idący.obraz.Location = idący.antyRozmycie.Location;
                    idący.przeszkoda = true;
                }
            }
        }
        /// <summary>
        /// Metoda sprawdza, czy na drodze postaci znajduje się przeszkoda. Jeśli tak, nie pozwala jej iść dalej.
        /// </summary>
        /// <param name="idący">Idąca postać</param>
        /// <param name="obiekt">Istniejąca przeszkoda</param>
        internal void przeszkodaNaDrodze(Launcher.ZmiennePostaci idący, Launcher.ZmiennePostaci obiekt)
        {
            if (obiekt.exists == true)
            {
                if (idący.obraz.Bounds.IntersectsWith(obiekt.obraz.Bounds))
                {
                    if (idący.obraz.Top <= obiekt.obraz.Bottom & idący.obraz.Top >= obiekt.obraz.Top & idący.obraz.Right >= obiekt.obraz.Left & idący.obraz.Left <= obiekt.obraz.Right)
                    {
                        idący.antyRozmycie.Top += 4;
                    }
                    if (idący.obraz.Bottom >= obiekt.obraz.Top & idący.obraz.Bottom >= obiekt.obraz.Bottom & idący.obraz.Right >= obiekt.obraz.Left & idący.obraz.Left <= obiekt.obraz.Right)
                    {
                        idący.antyRozmycie.Top -= 4;
                    }
                    if (idący.obraz.Right >= obiekt.obraz.Left & idący.obraz.Right <= obiekt.obraz.Right & idący.obraz.Bottom >= obiekt.obraz.Top & idący.obraz.Top <= obiekt.obraz.Bottom)
                    {
                        idący.antyRozmycie.Left -= 4;
                    }
                    if (idący.obraz.Left <= obiekt.obraz.Right & idący.obraz.Left >= obiekt.obraz.Left & idący.obraz.Bottom >= obiekt.obraz.Top & idący.obraz.Top <= obiekt.obraz.Bottom)
                    {
                        idący.antyRozmycie.Left += 4;
                    }

                    idący.obraz.Location = idący.antyRozmycie.Location;
                    idący.przeszkoda = true;
                }
            }
        }

        #endregion
        #region użytkowe
        /// <summary>
        /// Metoda wyliczająca, ile procent liczby1 stanowi liczba2
        /// </summary>
        /// <param name="liczba1">Liczba1 = 100% z liczby1</param>
        /// <param name="liczba2">Liczba2 = x% z liczby1</param>
        /// <returns></returns>
        internal int wyliczProcent(int liczba1, int liczba2)
        {
            return (liczba1 * 100) / liczba2;
        }

        /// <summary>
        /// Metoda losuje liczby z danego przedziału
        /// </summary>
        /// <param name="min">Wartość minimalna do wylosowania</param>
        /// <param name="max">Wartość maksymalna do wylosowania</param>
        /// <returns></returns>
        internal int losuj(int min,int max)
        {
            Random random = new Random();
            return random.Next(min, max+1);
        }     
           
        /// <summary>
        /// Metoda sprawdza czy forma jest aktualnie otwarta
        /// (Zaczerpnięta ze strony http://stackoverflow.com/questions/3861602/how-to-check-if-a-windows-form-is-already-open-and-close-it-if-it-is)
        /// </summary>
        /// <param name="name">Nazwa formy do sprawdzenia</param>
        /// <returns></returns>
        internal bool CheckOpened(string name)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Text == name)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Metoda wstrzymuje wszelkie akcje w wątku na okresloną liczbę sekund
        /// </summary>
        /// <param name="seconds">Liczba sekund</param>
        internal void wait(double seconds)
        {
            double miliseconds = seconds * 100;
            Thread.Sleep(Convert.ToInt32(miliseconds));
        }

        #endregion

        /// <summary>
        /// Metoda wykonująca operacje po osiągnięciu wyższego poziomu przez gracza
        /// </summary>
        internal void levelUp()
        {
            while (daneLauncher.daneGracz.exp >=daneLauncher.daneGracz.expMax)
            {
                daneLauncher.soundGracz.URL = "lvUp.wav";
                daneLauncher.soundGracz.Ctlcontrols.play();
                daneLauncher.daneGracz.lv++;
                daneLauncher.daneGracz.exp -= daneLauncher.daneGracz.expMax;
                daneLauncher.daneGracz.expMax += 5;
                daneLauncher.daneGracz.statystykiDoRozdania += 4;
                liczStatystyki();
                daneLauncher.daneGracz.hp = daneLauncher.daneGracz.hpMax;
                daneLauncher.daneGracz.mana = daneLauncher.daneGracz.manaMax;
            }
        }

        /// <summary>
        /// Metoda oblicza statytyki gracza
        /// </summary>
        internal void liczStatystyki()
        {
            dmgZwarcieGracz1();
            dmgZwarcieGracz2();
            dmgDystansGracz1();
            dmgDystansGracz2();
            hpMaxGracz();
            manaMaxGracz();
            szansaKrytykGracz();
        }

        /// <summary>
        /// Metoda sprawdza, czy obok postaci jest przedmiot do podniesienia. Jeżeli tak, to dodaje go do ekwipunku
        /// </summary>
        internal void podnieśDrop()
        {
            bool podniesiono = false;
            while (true)
            {
                podniesiono = sprawdzDostepnySlot(19, 332); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(71, 332); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(123, 332); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(175, 332); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(228, 332); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(280, 332); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(331, 332); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(383, 332); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(19, 386); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(71, 386); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(123, 386); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(175, 386); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(228, 386); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(280, 386); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(331, 386); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(383, 386); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(19, 437); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(71, 437); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(123, 437); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(175, 437); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(228, 437); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(280, 437); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(331, 437); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(383, 437); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(19, 488); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(71, 488); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(123, 488); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(175, 488); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(228, 488); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(280, 488); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(331, 488); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(383, 488); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(19, 542); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(71, 542); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(123, 542); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(175, 542); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(228, 542); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(280, 542); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(331, 542); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlot(383, 542); if (podniesiono == true) break;
                // komunikat brak miejsca w eq
                break;
            }
        }
        
        /// <summary>
        /// Metoda wyposaża automatycznie gracza w przedmiot, który został wywołałny komendą.
        /// </summary>
        /// <param name="LokacjaX"></param>
        /// <param name="LokacjaY"></param>
        internal void NałóżPrzedmiotKomendy(int LokacjaX, int LokacjaY)
        {
            for (int i = 1; i <= 46; i++)
            {
                if (daneLauncher.danePlecakSlot[i].Lokacja == new System.Drawing.Point(LokacjaX, LokacjaY))
                {
                    Launcher.ZmienneEkwipunku resetuj = new Launcher.ZmienneEkwipunku();
                    Point kopiaLokacji = new Point();
                    kopiaLokacji = daneLauncher.danePlecakSlot[i].Lokacja;
                    daneLauncher.danePlecakSlot[i] = daneLauncher.daneDropKomenda;
                    daneLauncher.daneDropKomenda.obraz.Visible = false;
                    daneLauncher.daneDropKomenda = resetuj;
                    daneLauncher.danePlecakSlot[i].Lokacja = kopiaLokacji;
                }
            }
        }

        /// <summary>
        /// Metoda sprawdza, czy w ekwipunku jest wolne miejsce na dodatkowy przedmiot. Jest używana w metodzie podnieśDrop().
        /// </summary>
        private bool sprawdzDostepnySlot(int LokacjaX, int LokacjaY)
        {
            for (int i = 0; i < 5; i++)
            {
                if (daneLauncher.daneDrop[i].exists == true)
                {
                    if (daneLauncher.daneGracz.obraz.Bounds.IntersectsWith(daneLauncher.daneDrop[i].obraz.Bounds))
                    {
                        for (int j = 1; j <= 46; j++)
                        {
                            if (daneLauncher.danePlecakSlot[j].Lokacja == new System.Drawing.Point(LokacjaX, LokacjaY) & daneLauncher.danePlecakSlot[j].exists == false & daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji==daneLauncher.daneDrop[i].numerLokacji)
                            {
                                Point kopiaLokacji = new Point();
                                kopiaLokacji = daneLauncher.danePlecakSlot[j].Lokacja;
                                daneLauncher.danePlecakSlot[j] = daneLauncher.daneDrop[i];
                                daneLauncher.daneDrop[i].obraz.Visible = false;
                                daneLauncher.daneDrop[i] = new Launcher.ZmienneEkwipunku();
                                daneLauncher.danePlecakSlot[j].Lokacja = kopiaLokacji;
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}
