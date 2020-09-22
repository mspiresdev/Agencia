using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AgenciaWebApi.Controllers
{
    public class ItinerarioController : ApiController
    {
        AgenciaDAL.Itinerario Dal = new AgenciaDAL.Itinerario();
        // GET: api/Itinerario
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Itinerario/5
        public AgenciaModel.Itinerario Get(int id)
        {
            if (id == 0)
                return new AgenciaModel.Itinerario() {  };

            return Dal.Get(id);

        }

        // POST: api/Itinerario
        public dynamic Post(AgenciaModel.Itinerario value)
        {
            return Dal.Lista(value);
        }

        // PUT: api/Itinerario/5
        public void Put(AgenciaModel.Itinerario value)
        {
            if (value.Id != 0)
                Dal.Update(value);
            else
                Dal.Salva(value);
        }

        // DELETE: api/Itinerario/5
        public void Delete(int id)
        {
        }
    }
}
