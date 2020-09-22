using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            AgenciaDAL.Pessoa.Insert(new AgenciaModel.Pessoa() { Nome = "marcos ", CNPJ = "2453534646", Juridica = false, UltimaAtualizacao = DateTime.Now, Registro = DateTime.Now });
        }
    }
}
