using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaModel;

namespace AgenciaDAL
{
   public class Reserva : GenericDAL<AgenciaModel.Reserva>
    {

        Contexto cx = new Contexto();

        public override AgenciaModel.Reserva Salva(AgenciaModel.Reserva dados)
        {
            return base.Salva(dados);
        }

        public override AgenciaModel.Reserva Update(AgenciaModel.Reserva dados)
        {
            return base.Update(dados);
        }


        public override void Delete(AgenciaModel.Reserva dados, int id)
        {
            base.Delete(dados, id);
        }

        public AgenciaModel.Reserva Get(int Id)
        {
            return cx.Reservas.Find(Id);
        }
        public dynamic Lista(AgenciaModel.Reserva reserva)
        {
            var query = cx.Reservas.Where(u => u.Visivel == true).AsQueryable();
          

            return query.Select(s => new {
                s.Id,
                s.Cliente,
                s.Agencia,
                s.Fornecedor,
                s.Inicio,
                s.Fim,
                s.Origem,
                s.Destino,
                s.NoVoo

            });
        }

        
    }
}
