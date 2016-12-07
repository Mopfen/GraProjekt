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
    public class Komendy
    {
        internal class MieczProgramisty
        {
            Launcher daneLauncher;

            public MieczProgramisty(Launcher dane)
            {
                daneLauncher = dane;
            }

            /// <summary>
            /// Metoda wczytuje sekwencję klawiszy dla komendy: MieczProgramisty
            /// </summary>
            /// <param name="e"></param>
            internal void WczytajKomendę(KeyEventArgs e)
            {
                if (e.KeyCode == Keys.S)
                {
                    if (daneLauncher.komenda == "")
                    {
                        daneLauncher.komenda += "s";
                    }
                    else daneLauncher.komendaOK = false;
                }
                if (e.KeyCode == Keys.Q)
                {
                    if (daneLauncher.komenda == "s")
                    {
                        daneLauncher.komenda += "q";
                    }
                    else daneLauncher.komendaOK = false;
                }
                if (e.KeyCode == Keys.U)
                {
                    if (daneLauncher.komenda == "sq")
                    {
                        daneLauncher.komenda += "u";
                    }
                    else daneLauncher.komendaOK = false;
                }
                if (e.KeyCode == Keys.A)
                {
                    if (daneLauncher.komenda == "squ" | daneLauncher.komenda == "squad")
                    {
                        daneLauncher.komenda += "a";
                    }
                    else daneLauncher.komendaOK = false;
                }
                if (e.KeyCode == Keys.D)
                {
                    if (daneLauncher.komenda == "squa")
                    {
                        daneLauncher.komenda += "d";
                    }
                    else daneLauncher.komendaOK = false;
                }
                if (e.KeyCode == Keys.K)
                {
                    if (daneLauncher.komenda == "squada")
                    {
                        daneLauncher.komenda += "k";
                    }
                    else daneLauncher.komendaOK = false;
                }
            }
            /// <summary>
            /// Metoda wykonuje komendę: MieczProgramisty
            /// </summary>
            /// <param name="forma"></param>
            internal void WykonajKomendę()
            {
                if (daneLauncher.komendaOK == false)
                {
                    daneLauncher.komenda = "";
                    daneLauncher.komendaOK = true;
                }
                if (daneLauncher.komenda == "squadak")
                {
                    MetodyEkwipunek metodaEkwipunek = new MetodyEkwipunek(daneLauncher);
                    daneLauncher.wpisanoKomendę = true;
                    daneLauncher.daneDropKomenda.exists = true;
                    daneLauncher.daneDropKomenda.miecz = true;
                    daneLauncher.daneDropKomenda.id = 1000;
                    daneLauncher.daneDropKomenda.obraz = daneLauncher.MieczSquadaka;
                    daneLauncher.daneDropKomenda.dmgZwarcie[0] = 9240;
                    daneLauncher.daneDropKomenda.dmgZwarcie[1] = 9480;
                    metodaEkwipunek.NałóżPrzedmiotKomendy(247, 170);
                    daneLauncher.daneDropKomenda.exists = true;
                    daneLauncher.daneDropKomenda.łuk = true;
                    daneLauncher.daneDropKomenda.id = 1001;
                    daneLauncher.daneDropKomenda.obraz = daneLauncher.ŁukSquadaka;
                    daneLauncher.daneDropKomenda.dmgDystans[0] = 9240;
                    daneLauncher.daneDropKomenda.dmgDystans[1] = 9480;
                    metodaEkwipunek.NałóżPrzedmiotKomendy(380, 170);
                    daneLauncher.komenda = "";                   
                }
            }
        }
    }
}
