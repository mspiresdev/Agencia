using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaModel
{
    public class Perfil : BaseModel
    {
        [Required]
        public string Nome { get; set; }
        public bool? FullAcesso { get; set; }

        public int? Hieranquia { get; set; }

        public virtual Usuario Usuario { get; set; }

        public int? Usuario_Id { get; set; }
    }
}
