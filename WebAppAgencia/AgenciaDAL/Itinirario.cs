using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaModel;

namespace AgenciaDAL
{
   public class Itinerario : GenericDAL<AgenciaModel.Itinerario>
    {

        Contexto cx = new Contexto();

        public override AgenciaModel.Itinerario Salva(AgenciaModel.Itinerario dados)
        {
            return base.Salva(dados);
        }

        public override AgenciaModel.Itinerario Update(AgenciaModel.Itinerario dados)
        {
            return base.Update(dados);
        }


        public override void Delete(AgenciaModel.Itinerario dados, int id)
        {
            base.Delete(dados, id);
        }


        public dynamic Lista(AgenciaModel.Itinerario reserva)
        {
            var query = cx.Itinerarios.Where(u => u.Visivel == true).AsQueryable();

            if (!string.IsNullOrEmpty(reserva.Nome))
                query = query.Where(u => u.Nome.Contains(reserva.Nome));

            return query;
        }

        public AgenciaModel.Itinerario Get(int Id)
        {
            return cx.Itinerarios.Find(Id);
        }

    }
}
