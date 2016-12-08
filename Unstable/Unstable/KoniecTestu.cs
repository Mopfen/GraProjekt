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
    /// <summary>
    /// Odpowiada za wyświetlenie komunikatu o zakończeniu testów w danej wersji gry
    /// </summary>
    public partial class KoniecTestu : Form
    {
        /// <summary>
        /// Pole daje dostęp do formy, która ma być zamknięta po zakończeniu testów w danej wersji gry
        /// </summary>
        Form daneForma;

        /// <summary> 
        /// Pole umożliwia dostęp do danych zawartych w klasie Launcher.
        /// </summary>
        Launcher daneLauncher;

        public KoniecTestu(Launcher dane, Form forma)
        {
            InitializeComponent();
            daneLauncher = dane;
            daneForma = forma;
        }

        private void KoniecTestu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                daneForma.Close();
                daneLauncher.Show();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
            daneForma.Close();
            daneLauncher.Show();
        }
    }
}
