﻿using System;
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
            CarregaTelaLogin();
        }

        private void CarregaSplash() {
            //TODO: Chamar tela de Inicio do Sistema
        }

        private void CarregaTelaLogin()
        {
            //TODO: CHamar tela de Login
            frmLogin telaLogin = new frmLogin();
            telaLogin.ShowDialog();
        }
    }
}
