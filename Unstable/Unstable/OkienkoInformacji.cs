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
    public partial class OkienkoInformacji : Form
    {
        public OkienkoInformacji()
        {
            InitializeComponent();
        }

        private void alaButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkienkoInformacji_KeyDown(object sender, KeyEventArgs e)
        {
            this.Close();
        }
    }
}
