using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace AgenciaWebApI.Controllers
{
    public class CentroCustoController : ApiController
    {

        //[HttpPost()]
        //[Route("api/centrocusto/GetList")]
        //[Authorize()]
        //public HttpResponseMessage GetList([FromBody]BE.Area area)
        //{
        //    try
        //    {
        //        return Request.CreateResponse(HttpStatusCode.OK, VerbaMarketingBC.CentroCusto.GetList(area));
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError,  VerbaUtil.Util.GetAllError(ex) );
        //    }
        //}
        // GET api/centrocusto
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/centrocusto/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/centrocusto
        public void Post([FromBody]string value)
        {
        }

        // PUT api/centrocusto/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/centrocusto/5
        public void Delete(int id)
        {
        }
    }
}
