using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaModel
{
    public class MaterialServico : BaseModel
    {
      

        [Required]
        public string Nome { get; set; }

        //public int? PessoaMaterial_Id { get; set; }

        //public virtual Pessoa PessoaMaterial { get; set; }

    }
}
