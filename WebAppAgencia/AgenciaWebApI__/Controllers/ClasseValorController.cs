using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace AgenciaWebApI.Controllers
{
    public class ClasseValorController : ApiController
    {
        //[HttpPost()]
        //[Route("api/classevalor/GetList")]
        //[Authorize()]
        //public HttpResponseMessage GetList([FromBody]BE.Entidade entidade)
        //{
        //    try
        //    {
        //        return Request.CreateResponse(HttpStatusCode.OK, VerbaMarketingBC.ClasseValor.GetList(entidade));
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError,  VerbaUtil.Util.GetAllError(ex) );
        //    }
        //}
        // GET api/classevalor
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/classevalor/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/classevalor
        public void Post([FromBody]string value)
        {
        }

        // PUT api/classevalor/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/classevalor/5
        public void Delete(int id)
        {
        }
    }
}
