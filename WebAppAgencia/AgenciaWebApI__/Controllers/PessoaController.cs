using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AgenciaWebApI.Controllers
{
    public class PessoaController : ApiController
    {
        AgenciaDAL.Pessoa Dal = new AgenciaDAL.Pessoa();
        // GET: api/Pessoa
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Pessoa/5
        public AgenciaModel.Pessoa Get(int id)
        {
            return Dal.Get(id);

        }

        // POST: api/Pessoa

        public dynamic Post([FromBody]AgenciaModel.Pessoa value)
        {
            return Dal.Lista(value);
        }

        // PUT: api/Pessoa/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Pessoa/5
        public void Delete(int id)
        {
        }
    }
}
