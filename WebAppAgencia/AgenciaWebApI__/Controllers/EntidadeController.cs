using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace AgenciaWebApI.Controllers
{
    public class EntidadeController : ApiController
    {

        //[HttpGet()]
        //[Route("api/entidade/GetList")]
        //[Authorize()]
        //// GET api/verbamarketing
        //public HttpResponseMessage GetList()
        //{
        //    try
        //    {
               
        //        return Request.CreateResponse(HttpStatusCode.OK, VerbaMarketingBC.Entidade.GetList());
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError,  VerbaUtil.Util.GetAllError(ex) );
        //    }
        //}
        // GET api/entidade
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/entidade/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/entidade
        public void Post([FromBody]string value)
        {
        }

        // PUT api/entidade/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/entidade/5
        public void Delete(int id)
        {
        }
    }
}
