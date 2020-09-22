using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AgenciaModel;

namespace AgenciaWebApi.Controllers
{
    public class ReservaController : ApiController
    {
        AgenciaDAL.Reserva Dal = new AgenciaDAL.Reserva();
        // GET: api/Reserva
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Reserva/5
        public dynamic Get(int id)
        {
            return Dal.Get(id);
        }

        // POST: api/Reserva
        public dynamic Post(AgenciaModel.Reserva value)
        {
            return Dal.Lista(value);
        }

        // PUT: api/Reserva/5
        public void Put(AgenciaModel.Reserva value)
        {
             RevomeVirtuais(value);

            if (value.Id != 0)
                Dal.Update(value);
            else
            {
                value.Nome = $"{ value.Cliente_Id} - {DateTime.Now.ToString("yyyyMMdd")}";
                Dal.Salva(value);
            }
        }

        private void RevomeVirtuais(Reserva value)
        {
            value.Origem = null;
            value.Destino = null;
            value.Cliente = null;
            value.Fornecedor = null;
            value.Agencia = null;
        }

        // DELETE: api/Reserva/5
        public void Delete(int id)
        {
        }
    }
}
