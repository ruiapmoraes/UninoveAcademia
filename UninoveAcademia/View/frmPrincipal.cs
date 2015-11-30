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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //TODO
            //CarregaSplash();
            CarregaTelaLogin();
        }

        private void CarregaSplash() {
            //TODO: Chamar tela de Inicio do Sistema
            frmSplash telaSplash = new frmSplash();
            telaSplash.Show();
        }

        private void CarregaTelaLogin()
        {            
            frmLogin telaLogin = new frmLogin();
            telaLogin.ShowDialog();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargo telaCargo = new frmCargo();
            telaCargo.ShowDialog();
        }
    }
}
