using _1Atividade.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Atividade.Controller
{
    internal class ControllerCadastro
    {
        public void EnviarBanco()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("PCadastro", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue(@"nome", Cadastros.Nome);
                cmd.Parameters.AddWithValue(@"cpf", Cadastros.Cpf);
                cmd.Parameters.AddWithValue(@"email", Cadastros.Email);
                cmd.Parameters.AddWithValue(@"telefone", Cadastros.Telefone);
                cmd.Parameters.AddWithValue(@"estado", Cadastros.Estado);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados inseridos com sucesso");
                 

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
