using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoCode64
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void TempoBarraProgressoSplash_Tick(object sender, EventArgs e)
        {
            try
            {
                //BarraProgressoSplash.Value = BarraProgressoSplash.Value + 1;
            }
            catch
            {
                //this.Visible = false;
                //Application.Exit();
            }
          
        }
    }
}
