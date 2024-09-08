using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Atividade.Model
{
    internal class Cadastros
    {
        private static int codigo;
        private static string nome;
        private static string cpf;
        private static string email;
        private static string telefone;
        private static string estado;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static string Nome { get => nome; set => nome = value; }
        public static string Cpf { get => cpf; set => cpf = value; }
        public static string Email { get => email; set => email = value; }
        public static string Telefone { get => telefone; set => telefone = value; }
        public static string Estado { get => estado; set => estado = value; }
    }
}
