using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UninoveAcademia.View
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }
        Timer tmr;
        private void frmSplash_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();
            tmr.Interval = 3000;
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            tmr.Stop();
            //frmPrincipal frmPrin = new frmPrincipal();
            //frmPrin.Show();
            CarregaTelaLogin();
            this.Hide();
        }

        private void CarregaTelaLogin()
        {
            frmLogin telaLogin = new frmLogin();
            telaLogin.ShowDialog();
        }
    }
}
