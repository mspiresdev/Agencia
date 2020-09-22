using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaModel
{
    public class Itinerario: BaseModel
    {
        [Required]
        public string Nome { get; set; }

        public string Descricao { get; set; }
    }
}
