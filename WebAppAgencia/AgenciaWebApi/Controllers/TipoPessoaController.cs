using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AgenciaWebApi.Controllers
{
    public class TipoPessoaController : ApiController
    {
        AgenciaDAL.TipoPessoa Dal = new AgenciaDAL.TipoPessoa();
        // GET: api/TipoPessoa
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/TipoPessoa/5
      

        // POST: api/TipoPessoa
        public dynamic Post(AgenciaModel.TipoPessoa value)
        {
            return Dal.Lista(value);
        }

        // PUT: api/TipoPessoa/5
        public dynamic Get(int id)
        {
            return Dal.Get(id);
        }

      
        // PUT: api/Reserva/5
        public void Put(AgenciaModel.TipoPessoa value)
        {
            if (value.Id != 0)
                Dal.Update(value);
            else
            {
                Dal.Salva(value);
            }
        }

    
        // DELETE: api/TipoPessoa/5
        public void Delete(int id)
        {
        }
    }
}
