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
    class MetodyEkwipunek
    {
        Launcher daneLauncher;

        public MetodyEkwipunek(Launcher dane)
        {
            daneLauncher = dane;
        }

        internal void aktualizujDaneWyposażenia()
        {
            for (int i = 1; i <= 46; i++)
            {
                //Hełm:
                if (daneLauncher.danePlecakSlot[i].obraz.Location == new Point(311, 40) & daneLauncher.danePlecakSlot[i].exists == true)
                {
                    // statystyki hełmu
                }
                //Zbroja:
                if (daneLauncher.danePlecakSlot[i].obraz.Location == new Point(311, 106) & daneLauncher.danePlecakSlot[i].exists == true)
                {
                    // statystyki zbroji
                }
                //Spodnie:
                if (daneLauncher.danePlecakSlot[i].obraz.Location == new Point(311, 170) & daneLauncher.danePlecakSlot[i].exists == true)
                {
                    // statystyki spodni
                }
                //Buty:
                if (daneLauncher.danePlecakSlot[i].obraz.Location == new Point(311, 236) & daneLauncher.danePlecakSlot[i].exists == true)
                {
                    // statystyki butów
                }
                //Miecz:
                if (daneLauncher.danePlecakSlot[i].obraz.Location == new Point(247, 170))
                {
                    if (daneLauncher.danePlecakSlot[i].exists == true)
                    {
                        daneLauncher.daneBonusyGracz.dmgZwarcie[0] = daneLauncher.danePlecakSlot[i].dmgZwarcie[0];
                        daneLauncher.daneBonusyGracz.dmgZwarcie[1] = daneLauncher.danePlecakSlot[i].dmgZwarcie[1];

                        daneLauncher.daneGracz.posiadaMiecz = true;
                    }
                    else
                    {
                        daneLauncher.daneBonusyGracz.dmgZwarcie[0] = 0;
                        daneLauncher.daneBonusyGracz.dmgZwarcie[1] = 0;

                        daneLauncher.daneGracz.posiadaMiecz = false;
                    }
                }
                //Łuk:
                if (daneLauncher.danePlecakSlot[i].obraz.Location == new Point(380, 170))
                {
                    if (daneLauncher.danePlecakSlot[i].exists == true)
                    {
                        daneLauncher.daneBonusyGracz.dmgDystans[0] = daneLauncher.danePlecakSlot[i].dmgDystans[0];
                        daneLauncher.daneBonusyGracz.dmgDystans[1] = daneLauncher.danePlecakSlot[i].dmgDystans[1];

                        daneLauncher.daneGracz.posiadaŁuk = true;
                    }
                    else
                    {
                        daneLauncher.daneBonusyGracz.dmgDystans[0] = 0;
                        daneLauncher.daneBonusyGracz.dmgDystans[1] = 0;

                        daneLauncher.daneGracz.posiadaŁuk = false;
                    }
                }
            }
        }

        internal bool czyPrzestawienieMożliwe(int numerSlotu, int i, int LocationX, int LocationY, PictureBox staraLokacja, bool przestaw, bool elementWyposażenia1, bool elementWyposażenia2)
        {
            if (przestaw == true & daneLauncher.danePlecakSlot[i].obraz.Location == new Point(LocationX, LocationY))
            {
                if (elementWyposażenia1 == false)
                {
                    return false;
                }
            }
            if (przestaw == true & staraLokacja.Location == new Point(LocationX, LocationY))
            {
                if (elementWyposażenia2 == false & daneLauncher.danePlecakSlot[i].exists == true)
                {
                    return false;
                }
            }
            if (przestaw == false)
            {
                return false;
            }
            return true;
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
        /// Metoda dodaje przedmiot fabularny do ekwipunku
        /// </summary>
        internal void DodajFabularnyItem()
        {
            bool podniesiono = false;
            while (true)
            {
                podniesiono = sprawdzDostepnySlotFabularny(21, 90); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlotFabularny(73, 90); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlotFabularny(125, 90); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlotFabularny(177, 90); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlotFabularny(229, 90); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlotFabularny(281, 90); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlotFabularny(333, 90); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlotFabularny(385, 90); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlotFabularny(21, 142); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlotFabularny(73, 142); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlotFabularny(125, 142); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlotFabularny(177, 142); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlotFabularny(229, 142); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlotFabularny(281, 142); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlotFabularny(333, 142); if (podniesiono == true) break;
                podniesiono = sprawdzDostepnySlotFabularny(385, 142); if (podniesiono == true) break;
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
        /// Metoda sprawdza, czy gracz posiada wymgany przedmiot fabularny. Jeśli tak, używa go.
        /// </summary>
        internal bool użyjFabularnegoItemu(int id)
        {
            for(int i=1; i<=16; i++)
            {
                if(daneLauncher.daneFabularnyItem[i].id==id)
                {
                    daneLauncher.daneFabularnyItem[i] = new Launcher.ZmienneEkwipunku();
                    return true;
                }
            }
            return false;
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
                            if (daneLauncher.danePlecakSlot[j].Lokacja == new System.Drawing.Point(LokacjaX, LokacjaY) & daneLauncher.danePlecakSlot[j].exists == false & daneLauncher.daneMapa[daneLauncher.numerMapy].numerLokacji == daneLauncher.daneDrop[i].numerLokacji)
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

        /// <summary>
        /// Metoda sprawdza, czy w ekwipunku jest wolne miejsce na przedmiot fabularny. Jest używana w metodzie DodajFabularnyItem(int id).
        /// </summary>
        private bool sprawdzDostepnySlotFabularny(int LokacjaX, int LokacjaY)
        {
            for (int i = 0; i < 5; i++)
            {
                if (daneLauncher.daneDrop[i].exists == true & daneLauncher.daneDrop[i].fabularny == true)
                {                
                    for (int j = 1; j <= 16; j++)
                    {
                        if (daneLauncher.daneFabularnyItem[j].Lokacja == new System.Drawing.Point(LokacjaX, LokacjaY) & daneLauncher.daneFabularnyItem[j].exists == false)
                        {
                            Point kopiaLokacji = new Point();
                            kopiaLokacji = daneLauncher.daneFabularnyItem[j].Lokacja;
                            daneLauncher.daneFabularnyItem[j] = daneLauncher.daneDrop[i];
                            daneLauncher.daneDrop[i].obraz.Visible = false;
                            daneLauncher.daneDrop[i] = new Launcher.ZmienneEkwipunku();
                            daneLauncher.daneFabularnyItem[j].Lokacja = kopiaLokacji;
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
