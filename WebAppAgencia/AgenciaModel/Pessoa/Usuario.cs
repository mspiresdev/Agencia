using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaModel
{
    public class Usuario : BaseModel
    {
        public virtual Pessoa Pessoa { get; set; }

        public int Pessoa_Id { get; set; }
        [Required]
        public string Usu { get; set; }
        [Required]
        public string Senha { get; set; }

        public virtual List<Perfil> Perfis { get; set; }
    }
}
