using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unstable
{
    /// <summary> Zawiera metody używane w wątkach </summary>
    class Wątki
    {
        public Wątki() { }

        /// <summary>
        /// Metoda pozwala modyfikować atrybuty kontrolek form wewnątrz wątku.
        /// </summary>
        /// <param name="forma">Forma, w której znajduje się dana kontrolka</param>
        /// <param name="a">Atrybut kontrolki do modyfikacji</param>
        /// <param name="b">Wartość, jaka ma być przypisana atrybutowi kontrolki</param>
        public static void editInThread(Form forma, int input, Action<int> output)
        {
            forma.Invoke((MethodInvoker)delegate
            {
                output(input);
            });
        }
        /// <summary>
        /// Metoda pozwala modyfikować atrybuty kontrolek form wewnątrz wątku.
        /// </summary>
        /// <param name="forma">Forma, w której znajduje się dana kontrolka</param>
        /// <param name="a">Atrybut kontrolki do modyfikacji</param>
        /// <param name="b">Wartość, jaka ma być przypisana atrybutowi kontrolki</param>
        public static void editInThread(Form forma, bool input, Action<bool> output)
        {
            forma.Invoke((MethodInvoker)delegate
            {
                output(input);
            });
        }
        /// <summary>
        /// Metoda pozwala modyfikować atrybuty kontrolek form wewnątrz wątku.
        /// </summary>
        /// <param name="forma">Forma, w której znajduje się dana kontrolka</param>
        /// <param name="a">Atrybut kontrolki do modyfikacji</param>
        /// <param name="b">Wartość, jaka ma być przypisana atrybutowi kontrolki</param>
        public static void editInThread(Form forma, string input, Action<string> output)
        {
            forma.Invoke((MethodInvoker)delegate
            {
                output(input);
            });
        }
    }
}
