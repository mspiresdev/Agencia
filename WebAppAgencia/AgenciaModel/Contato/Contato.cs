using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaModel
{
    public class Contato  : BaseModel
    {
      
        public virtual Pessoa Pessoa { get; set; }
       
        public int? Pessoa_Id { get; set; }


       
        [Required]
        public string Descricao { get; set; }
        [Required]
        public string Numero { get; set; }
        [Required]
        public string Tipo { get; set; }
    }
}
