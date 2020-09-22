using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaModel
{
    public class Endereco : BaseModel
    {

      
        public virtual Pessoa Pessoa { get; set; }
       
        public int? Pessoa_Id { get; set; }


       
        [Required]
        public string Logradouro { get; set; }
        [Required]
        public int Numero { get; set; }

        public string Complemento { get; set; }

        public string Cep { get; set; }
    }
}
