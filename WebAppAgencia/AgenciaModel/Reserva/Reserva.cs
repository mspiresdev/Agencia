using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaModel
{
    public class Reserva : BaseModel
    {
       

        [Required]
        public string Nome { get; set; }

       
        public string Numero { get { return base.Registro.Year + base.Registro.Month + Id.ToString(); }  }

        public int? Cliente_Id { get; set; }
        public virtual Pessoa Cliente { get; set; }

        public int? Agencia_Id { get; set; }
        public virtual Pessoa Agencia { get; set; }

        public int? Origem_Id { get; set; }
        public virtual Itinerario Origem { get; set; }

        public int? Destino_Id { get; set; }
        public virtual Itinerario Destino { get; set; }

        public int? Fornecedor_Id { get; set; }
        public virtual Pessoa Fornecedor { get; set; }

        public string NoVoo { get; set; }

        public DateTime? Inicio { get; set; }
        public DateTime? Fim { get; set; }

      
        public  List<ReservaServico> ReservaServicos { get; set; }

        public double? Custo { get; set; }
        public double? Comissao { get; set; }

        public Reserva()
        {
            ReservaServicos = new List<ReservaServico>();
        }

    }
}
