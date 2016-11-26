using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unstable
{
    class ZmianaWygladu
    {
        Launcher daneLauncher;

        public ZmianaWygladu(Launcher dane)
        {
            daneLauncher = dane;
        }

        /// <summary>
        /// Metoda, po spełnieniu okreslonych warunków zmienia wygląd postaci
        /// </summary>
        /// <param name="postać"></param>
        internal void ZmieńWygląd(Launcher.ZmiennePostaci postać)
        {
            if ((postać.up == false & postać.down == false & postać.left == false & postać.right == false)) { postać.obraz.Image = daneLauncher.whiteBrownStand.Image; } // obraz postaci, gdy się nie rusza
            if (postać.antyRozmycie.Location != postać.obraz.Location & postać.przeszkoda==false) { postać.antyRozmycie.Location = postać.obraz.Location; } // niweluje rozmycie tła podczas poruszania się postaci

            if (postać.up == true & postać.down != true)
            {
                if (postać.zmianaKierunkuUp == false)
                {
                    postać.obraz.Image = daneLauncher.whiteBrownMovingUp.Image; postać.zmianaKierunkuUp = true;
                }
                if (postać.left == true | postać.right == true)
                {
                    postać.zmianaKierunkuDown = postać.zmianaKierunkuLeft = postać.zmianaKierunkuRight = false;
                }
            }
            else
            {
                if (postać.down == true & postać.up != true)
                {
                    if (postać.zmianaKierunkuDown == false)
                    {
                        postać.obraz.Image = daneLauncher.whiteBrownMovingDown.Image; postać.zmianaKierunkuDown = true;
                    }
                    if (postać.left == true | postać.right == true)
                    {
                        postać.zmianaKierunkuUp = postać.zmianaKierunkuLeft = postać.zmianaKierunkuRight = false;
                    }
                }
                else
                {
                    if (postać.left == true & postać.right != true)
                    {
                        if (postać.zmianaKierunkuLeft == false)
                        {
                            postać.obraz.Image = daneLauncher.whiteBrownMovingLeft.Image; postać.zmianaKierunkuLeft = true;
                        }
                        if (postać.up == true | postać.down == true)
                        {
                            postać.zmianaKierunkuUp = postać.zmianaKierunkuDown = postać.zmianaKierunkuRight = false;
                        }
                    }
                    else
                    {
                        if (postać.right == true & postać.left != true)
                        {
                            if (postać.zmianaKierunkuRight == false)
                            {
                                postać.obraz.Image = daneLauncher.whiteBrownMovingRight.Image; postać.zmianaKierunkuRight = true;
                            }
                            if (postać.up == true | postać.down == true)
                            {
                                postać.zmianaKierunkuUp = postać.zmianaKierunkuDown = postać.zmianaKierunkuLeft = false;
                            }
                        }
                        else
                        {
                            if ((postać.up == true & postać.down == true) | (postać.left == true & postać.right == true))
                            {
                                postać.obraz.Image = daneLauncher.whiteBrownStand.Image;
                                postać.zmianaKierunkuUp = postać.zmianaKierunkuDown = postać.zmianaKierunkuLeft = postać.zmianaKierunkuRight = false;
                            }
                        }
                    }
                }
            }
        }
    }
}
