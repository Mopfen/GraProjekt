using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            dmg += daneLauncher.daneGracz[0].siła *0.8;

            daneLauncher.daneGracz[0].siłaAtakuZwarcie[0] = (int)dmg;
        }
        internal void dmgZwarcieGracz2()
        {
            int dmg = 0;

            dmg += daneLauncher.daneGracz[0].siła;

            daneLauncher.daneGracz[0].siłaAtakuZwarcie[1] = dmg;
        }

        internal void dmgDystansGracz1()
        {
            double dmg = 0;

            dmg += daneLauncher.daneGracz[0].zręczność * 0.8;

            daneLauncher.daneGracz[0].siłaAtakuDystans[0] = (int)dmg;
        }
        internal void dmgDystansGracz2()
        {
            int dmg = 0;

            dmg += daneLauncher.daneGracz[0].zręczność;

            daneLauncher.daneGracz[0].siłaAtakuDystans[1] = dmg;
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
        internal void strzałaTrafienie(Launcher []obiekt, int ilosc)
        {
            for (int i = 0; i < ilosc; i++)
            {
                if (obiekt[i].alive == true)
                {
                    if (daneLauncher.daneStrzała[0].obraz.Bounds.IntersectsWith(obiekt[i].obraz.Bounds))
                    {
                        if (obiekt == daneLauncher.daneMob)
                        {
                            if (daneLauncher.daneMob[i].alive == true)
                            {
                                daneLauncher.daneStrzała[0].alive = false;
                                daneLauncher.daneStrzała[0].obraz.Visible = false;
                                int dmg = losuj(daneLauncher.daneGracz[0].siłaAtakuDystans[0], daneLauncher.daneGracz[0].siłaAtakuDystans[1]);
                                obiekt[i].hp -= dmg;
                                daneLauncher.hitLog.Text = ("Mopfen zadaje " + dmg + " obrażeń.\n" + daneLauncher.hitLog.Text);
                            }
                        }
                        if (obiekt == daneLauncher.danePrzeszkoda)
                        {
                            daneLauncher.daneStrzała[0].alive = false;
                            daneLauncher.daneStrzała[0].obraz.Visible = false;
                            obiekt[i].alive = false;
                            obiekt[i].obraz.Visible = false;
                        }
                    }
                }
            }
        }

        internal bool śmierćGracza()
        {
            if (daneLauncher.daneGracz[0].hp <= 0)
            {
                daneLauncher.daneGracz[0].hp = 0;
                return true;
            }
            return false;
        }
        internal Tuple<bool,int> śmierćMoba()
        {
            int i = 0;
            bool zabity = false;
            Tuple<bool, int> wynik = new Tuple<bool, int>(zabity, i);
            for (i = 0; i < 4; i++)
            {
                if(daneLauncher.daneMob[i].alive==true)
                {
                    if (daneLauncher.daneMob[i].hp <= 0)
                    {
                        daneLauncher.daneMob[i].hp = 0;
                        zabity = true;
                        daneLauncher.hitLog.Text = "Mob zostaje zabity!\n" + daneLauncher.hitLog.Text;
                        if (daneLauncher.daneGracz[0].lv == daneLauncher.daneMob[i].lv) daneLauncher.daneGracz[0].exp +=5;
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
        internal void atakwCelObok(Launcher []obiekt, int ilosc)
        {
            for (int i = 0; i < ilosc; i++)
            {
                if (obiekt[i].alive == true)
                {
                    if ((daneLauncher.daneGracz[0].left == true & (daneLauncher.daneGracz[0].obraz.Left - obiekt[i].obraz.Left >= (60) & daneLauncher.daneGracz[0].obraz.Left - obiekt[i].obraz.Right < 8 & (obiekt[i].obraz.Top - daneLauncher.daneGracz[0].obraz.Top >= (-64) & obiekt[i].obraz.Top - daneLauncher.daneGracz[0].obraz.Top < daneLauncher.daneGracz[0].obraz.Height)) |
                     (daneLauncher.daneGracz[0].right == true & (obiekt[i].obraz.Left - daneLauncher.daneGracz[0].obraz.Left >= (-60) & obiekt[i].obraz.Left - daneLauncher.daneGracz[0].obraz.Right < 8 & (obiekt[i].obraz.Top - daneLauncher.daneGracz[0].obraz.Top >= (-64) & obiekt[i].obraz.Top - daneLauncher.daneGracz[0].obraz.Top < daneLauncher.daneGracz[0].obraz.Height)))))
                    {
                        if(obiekt==daneLauncher.daneMob)
                        {
                            dmgZwarcieGracz1();
                            dmgZwarcieGracz2();
                            int dmg = losuj(daneLauncher.daneGracz[0].siłaAtakuZwarcie[0], daneLauncher.daneGracz[0].siłaAtakuZwarcie[1]);
                            obiekt[i].hp -= dmg;
                            daneLauncher.hitLog.Text = ("Mopfen zadaje " + dmg + " obrażeń.\n" + daneLauncher.hitLog.Text);
                        }
                        if(obiekt==daneLauncher.danePrzeszkoda)
                        {
                            obiekt[i].alive = false;
                            obiekt[i].obraz.Visible = false;
                        }
                    }
                }
            }
        }

        #endregion
        #region poruszanieSię

        internal void przeszkodaNaDrodze(Launcher idący, Launcher obiekt)
        {
            if(obiekt.alive==true)
            {
                if (idący.up == true & idący.obraz.Top - obiekt.obraz.Top >= (obiekt.obraz.Height-4) & idący.obraz.Top - obiekt.obraz.Bottom < 4 & (obiekt.obraz.Left - idący.obraz.Left >= (-obiekt.obraz.Width) & obiekt.obraz.Left - idący.obraz.Left < idący.obraz.Width)) { idący.obraz.Top += 4; idący.przeszkoda = true; }
                if (idący.down == true & obiekt.obraz.Bottom - idący.obraz.Bottom >= (obiekt.obraz.Height - 4) & obiekt.obraz.Top - idący.obraz.Bottom < 4 & (obiekt.obraz.Left - idący.obraz.Left >= (-obiekt.obraz.Width) & obiekt.obraz.Left - idący.obraz.Left < idący.obraz.Width)) { idący.obraz.Top -= 4; idący.przeszkoda = true; }
                if (idący.left == true & idący.obraz.Left - obiekt.obraz.Left >= (obiekt.obraz.Width - 4) & idący.obraz.Left - obiekt.obraz.Right < 0 & (obiekt.obraz.Top - idący.obraz.Top >= (-obiekt.obraz.Height) & obiekt.obraz.Top - idący.obraz.Top < idący.obraz.Height)) { idący.obraz.Left += 2; idący.przeszkoda = true; }
                if (idący.right == true & obiekt.obraz.Left - idący.obraz.Left >= (-obiekt.obraz.Width - 4) & obiekt.obraz.Left - idący.obraz.Right < 0 & (obiekt.obraz.Top - idący.obraz.Top >= (-obiekt.obraz.Height) & obiekt.obraz.Top - idący.obraz.Top < idący.obraz.Height)) { idący.obraz.Left -= 2; idący.przeszkoda = true; }
            }    
        }

        #endregion
        #region użytkowe
        internal int wyliczProcent(int liczba1, int liczba2)
        {
            return (liczba1 * 100) / liczba2;
        }
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
        #endregion

        internal bool levelUp()
        {
            if(daneLauncher.daneGracz[0].exp >=daneLauncher.daneGracz[0].expMax)
            {
                daneLauncher.daneGracz[0].lv++;
                daneLauncher.daneGracz[0].exp -= daneLauncher.expMax;
                daneLauncher.daneGracz[0].expMax += 5;
                return true;
            }
            return false;
        }

    }
}
