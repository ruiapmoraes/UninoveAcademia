using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace UninoveAcademia.ADO
{
    public class LoginADO
    {
        public bool VerificaLoginADO(string usuario, string senha)
        {
            bool resultado = false;
            string conexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GitHubUninove\2SEM_2015\UninoveAcademia\UninoveAcademia\AcademiaUninove.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection();
            SqlDataAdapter da = null;

            conn.ConnectionString = conexao;
                

                try
                {
                    SqlCommand cmd = new SqlCommand("select usuario, senha from Login Where usuario = '" + usuario +
                        "' and senha = '" + senha + "'", conn);
                    conn.Open();
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0 && dt != null)
                    resultado = true;
                
                }
                catch (Exception)
                {

                    throw;
                }
            
            return resultado;
        }
    }
}
