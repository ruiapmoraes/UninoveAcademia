using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UninoveAcademia.Negocio;
using UninoveAcademia.Classes;
using UninoveAcademia.View;

namespace UninoveAcademia
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        // Chamada de objetos
        #region Variáveis globais
        LoginBO objLoginBO = new LoginBO();
        Login objLoginDTO = new Login();

        string strMensagem = string.Empty; 
        #endregion

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            VerificaLogin();
        }

        private void VerificaLogin()
        {
            if (CamposPreechidos(txtUsuario.Text) && CamposPreechidos(txtSenha.Text))
            {
                //Verificar usuario no banco
                MessageBox.Show("O campo está nulo.");
                return;
            }
            else
            {
                objLoginDTO.Usuario = txtUsuario.Text.Trim();
                objLoginDTO.Senha = txtSenha.Text.Trim();

                bool resultado = objLoginBO.VerificaLogin(objLoginDTO.Usuario, objLoginDTO.Senha);

                if (resultado)
                {
                    MessageBox.Show("Usuário " + objLoginDTO.Usuario + " logado com sucesso. ", "Academia Univnove");
                    //TODO: Em caso de sucesso, redirecionar para o formulário principal
                    this.Close();

                }
            }
        }

        /// <summary>
        /// Campos Preenchidos
        /// </summary>
        /// <param name="campo">Campo</param>
        /// <returns>Retorna se o campo está nulo</returns>
        private bool CamposPreechidos(string campo)
        {
            if (!string.IsNullOrEmpty(campo))
            {
                return false;
            }
            else
                return true;
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VerificaLogin();
            }
        }
    }
}
