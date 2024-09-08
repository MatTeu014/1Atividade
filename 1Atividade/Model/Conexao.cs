using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1Atividade.Model
{
    internal class Conexao
    {
       public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\matpa\source\repos\1Atividade\1Atividade\Dados\bdCadastro.mdf;Integrated Security=True";
        }
    }
}
