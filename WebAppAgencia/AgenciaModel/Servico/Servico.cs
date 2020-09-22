using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaModel
{
    public class Servico : BaseModel
    {
      

        [Required]
        public string Nome { get; set; }

        public double? ValorPadrao { get; set; }

        public double? Custo { get; set; }
        public double? Comissao { get; set; }

        public List<MaterialServico> Materiais { get; set; }

    }
}
