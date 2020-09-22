using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AgenciaWebApI.Controllers
{
    public class PlanoEstrategicoController : ApiController
    {
        //[HttpGet()]
        //[Route("api/planoestrategico/GetList")]
        //[Authorize()]
        //public HttpResponseMessage GetList()
        //{
        //    try
        //    {
        //        return Request.CreateResponse(HttpStatusCode.OK, VerbaMarketingBC.PlanoEstrategico.GetList());
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError,  VerbaUtil.Util.GetAllError(ex)); 
        //    }
        //}

        //[HttpGet()]
        //[Route("api/planoestrategico/GetListv")]
        //[Authorize()]
        //public HttpResponseMessage GetListv()
        //{
        //    try
        //    {
        //        return Request.CreateResponse(HttpStatusCode.OK, VerbaMarketingBC.PlanoEstrategico.GetListv());
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError,  VerbaUtil.Util.GetAllError(ex) );
        //    }
        //}

        //[HttpGet()]
        //[Route("api/planoestrategico/GetItem/{id}")]
        //[Authorize()]
        //public HttpResponseMessage GetItem(int id)
        //{
        //    try
        //    {
        //        if (id != 0)
        //            return Request.CreateResponse(HttpStatusCode.OK, VerbaMarketingBC.PlanoEstrategico.GetList().Where(u=> u.ID == id).FirstOrDefault());
        //        else
        //            return Request.CreateResponse(HttpStatusCode.OK, new BE.PlanoEstrategico() { });
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError,  VerbaUtil.Util.GetAllError(ex) );
        //    }
        //}

        //[HttpGet()]
        //[Route("api/planoestrategico/Delete/{id}")]
        //[Authorize()]
        //public HttpResponseMessage Delete(int id)
        //{
        //    try
        //    {
        //        VerbaMarketingBC.PlanoEstrategico.Remove(id);
        //        return Request.CreateResponse(HttpStatusCode.OK, VerbaMarketingBC.PlanoEstrategico.GetList());
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError, VerbaUtil.Util.GetAllError(ex));
        //    }
        //}

        //[HttpPost()]
        //[Route("api/planoestrategico/Insert")]
        //[Authorize()]
        //public HttpResponseMessage Insert([FromBody]BE.PlanoEstrategico plano)
        //{
        //    try
        //    {
        //        VerbaMarketingBC.PlanoEstrategico.Insert(plano);
        //        return Request.CreateResponse(HttpStatusCode.OK,true );
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError,  VerbaUtil.Util.GetAllError(ex) );
        //    }
        //}
      
    }
}
