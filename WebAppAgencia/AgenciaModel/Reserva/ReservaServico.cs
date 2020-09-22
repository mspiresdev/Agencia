using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaModel
{
    public class ReservaServico 
    {
        public int? Reserva_Id { get; set; }
        public virtual Reserva Reserva { get; set; }

        public int? Servico_Id { get; set; }
        public virtual Servico Servico { get; set; }

    }
}
