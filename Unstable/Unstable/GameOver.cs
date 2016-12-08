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
    /// Odpowiada za wyświetlanie komunikatu "GameOver" po smierci gracza
    /// </summary>
    public partial class GameOver : Form
    {
        /// <summary>
        /// Pole odpowiada za dostęp do formy, która ma być zamknięta po śmierci gracza
        /// </summary>
        Form daneForma;

        /// <summary> 
        /// Pole umożliwia dostęp do danych zawartych w klasie Launcher.
        /// </summary>
        Launcher daneLauncher;

        public GameOver(Launcher dane, Form forma)
        {
            InitializeComponent();
            daneLauncher = dane;
            daneForma = forma;
        }

        private void GameOver_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                daneForma.Close();
                daneLauncher.Show();
            }
        }
    }
}
