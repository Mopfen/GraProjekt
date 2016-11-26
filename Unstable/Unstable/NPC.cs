using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unstable
{
    class NPC
    {
        Launcher daneLauncher;

        public NPC(Launcher dane)
        {
            daneLauncher = dane;
        }

        /// <summary>
        /// Metoda kierująca NPC do punktu x0 na osi X
        /// </summary>
        /// <param name="npc">NPC, który ma być poruszony</param>
        /// <param name="x0">Punkt na osi X, do którego ma się udać NPC </param>
        /// <param name="liczbaX">Należy podać liczbę X w nazwie metody lub nie wpisywać wcale, aby metoda działała poprawnie</param>
        internal void MoveToX(Launcher.ZmiennePostaci npc, int x0, short liczbaX=1)
        {
            npc.left = npc.right = false;

            bool xLeft = false;
            bool xRight = false;

            if (npc.obraz.Location.X > x0 - 3 | npc.obraz.Location.X > x0 + 3)
            {
                npc.left = true;
            }
            else xLeft = true;
            if (npc.obraz.Location.X < x0 - 3 | npc.obraz.Location.X < x0 + 3)
            {
                npc.right = true;
            }
            else xRight = true;
            if(xLeft == xRight == true)
            {
                npc.dotartoDoX[liczbaX-1] = true;
            }
        }
        /// <summary>
        /// Metoda kierująca NPC po kolei do punktów x0, x1 na osi X
        /// </summary>
        /// <param name="npc">NPC, który ma być poruszony</param>
        /// <param name="x0">Punkt na osi X, do którego ma się udać NPC</param>
        /// <param name="x1">Punkt na osi X, do którego ma się udać NPC</param>
        /// <param name="pętla">Czy metoda ma się zapętlać (jeśli puste, metoda nie zapętli się)</param>
        internal void MoveToXX(Launcher.ZmiennePostaci npc, int x0, int x1, bool pętla = false)
        {
            short liczbaX = 2;
            if(npc.dotartoDoX[0]==false)
            {
                MoveToX(npc, x0);
            }
            else
            {
                MoveToX(npc, x1, liczbaX);
            }
            if(pętla==true & npc.dotartoDoX[0]==true & npc.dotartoDoX[1]==true)
            {
                npc.dotartoDoX[0] = npc.dotartoDoX[1] = false;
            }
        }
        /// <summary>
        /// Metoda kierująca NPC do punktu y0 na osi Y
        /// </summary>
        /// <param name="npc">NPC, który ma być poruszony</param>
        /// <param name="x0">Punkt na osi Y, do którego ma się udać NPC </param>
        /// <param name="liczbaX">Należy podać liczbę Y w nazwie metody lub nie wpisywać wcale, aby metoda działała poprawnie</param>
        internal void MoveToY(Launcher.ZmiennePostaci npc, int y0, short liczbaY = 1)
        {
            npc.up = npc.down = false;

            bool yUp = false;
            bool yDown = false;

            if (npc.obraz.Location.Y > y0 - 3 | npc.obraz.Location.Y > y0 + 3)
            {
                npc.up = true;
            }
            else yUp = true;
            if (npc.obraz.Location.Y < y0 - 3 | npc.obraz.Location.Y < y0 + 3)
            {
                npc.down = true;
            }
            else yDown = true;
            if (yUp == yDown == true)
            {
                npc.dotartoDoY[liczbaY - 1] = true;
            }
        }
        /// <summary>
        /// Metoda kierująca NPC po kolei do punktów y0, y1 na osi Y
        /// </summary>
        /// <param name="npc">NPC, który ma być poruszony</param>
        /// <param name="x0">Punkt na osi Y, do którego ma się udać NPC</param>
        /// <param name="x1">Punkt na osi Y, do którego ma się udać NPC</param>
        /// <param name="pętla">Czy metoda ma się zapętlać (jeśli puste, metoda nie zapętli się)</param>
        internal void MoveToYY(Launcher.ZmiennePostaci npc, int y0, int y1, bool pętla = false)
        {
            short liczbaY = 2;
            if (npc.dotartoDoY[0] == false)
            {
                MoveToY(npc, y0);
            }
            else
            {
                MoveToY(npc, y1, liczbaY);
            }
            if (pętla == true & npc.dotartoDoY[0] == true & npc.dotartoDoY[1] == true)
            {
                npc.dotartoDoY[0] = npc.dotartoDoY[1] = false;
            }
        }
    }
}
