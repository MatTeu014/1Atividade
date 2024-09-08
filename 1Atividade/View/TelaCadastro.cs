using _1Atividade.Controller;
using _1Atividade.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1Atividade.View
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Cadastros.Nome = tbx_nome.Text;
            Cadastros.Cpf = tbx_cpf.Text;
            Cadastros.Email = tbx_email.Text;
            Cadastros.Telefone = tbx_telefone.Text;
            Cadastros.Estado = btn_cadastrar.Text;

            ControllerCadastro controllercadastro = new ControllerCadastro();
            controllercadastro.EnviarBanco();
        }
    }
}
