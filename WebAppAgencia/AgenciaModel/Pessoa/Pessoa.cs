using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaModel
{
    public class Pessoa : BaseModel
    {
        //public int? PessoaEmp_Id { get; set; }
        //public virtual Pessoa PessoaEmp { get; set; }

       
        public string RazaoSocial { get; set; }

        [Required]
        public string Nome { get; set; }
        [Required]
        public bool Juridica { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string CNH { get; set; }

        public string NrCadastur { get; set; }

        public virtual List<Endereco> Enderecos { get; set; }
        public virtual List<Contato> Contatos { get; set; }
        public virtual List<Veiculo> Veiculos { get; set; }

    

        // public virtual List<Pessoa> Colaboradores { get; set; }

        public bool Responsavel { get; set; }


        public int TipoPessoa_Id { get; set; }
        public virtual TipoPessoa TipoPessoa { get; set; }

        public int? Usuario_Id { get; set; }
        public virtual Usuario Usuario { get; set; }

        public Pessoa()
        {
            Enderecos = new List<Endereco>();
            Contatos = new List<Contato>();
            Veiculos = new List<Veiculo>();
          //  Colaboradores = new List<Pessoa>();
        }

        public static class CodTipo
        {
            public const int Cliente = 1;
            public const int Fornecedor = 2;
            public const int Agencia = 2;
        }

       
    }


}
