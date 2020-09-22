using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaModel
{
   public class Veiculo : BaseModel
    {
        public virtual Pessoa Pessoa { get; set; }

        public int? Pessoa_Id { get; set; }

        [Required]
        public string Placa { get; set; }

       
        public string Modelo { get; set; }

      
        public int Assentos { get; set; }

        public int Obs { get; set; }
    }
}
