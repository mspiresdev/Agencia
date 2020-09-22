using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Transactions;
using System.Configuration;
using System.Text;
using System.Net.Http.Headers;

namespace AgenciaWebApI.Controllers
{
    public class VerbaMarketingController : ApiController
    {
        

        // [HttpGet()]
        // [Route("api/usuario/GetItem/{lg}")]
        // [Authorize()]
        //// GET api/verbamarketing
        //public HttpResponseMessage GetItemUser(string lg)
        //{
        //    try
        //    {
        //        return Request.CreateResponse(HttpStatusCode.OK, VerbaMarketingBC.SolicitacaoVerba.GetItemUser(lg));
               
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError,  VerbaUtil.Util.GetAllError(ex) );
        //    }
        //}

        // [HttpGet()]
        // [Route("api/verbamarketing/GetToday")]
        // //[Authorize()]
        // // GET api/verbamarketing
        // public HttpResponseMessage GetToday()
        // {
        //     try
        //     {
        //         return Request.CreateResponse(HttpStatusCode.OK, VerbaMarketingBC.SolicitacaoVerba.GetListToday());
        //     }
        //     catch (Exception ex)
        //     {
        //         return Request.CreateResponse(HttpStatusCode.InternalServerError, this.ActionContext.Request.RequestUri.ToString() + VerbaUtil.Util.GetAllError(ex));
        //     }
        // }

        //[HttpGet()]
        //[Route("api/verbamarketing/Get/{id}/{tk}")]
        ////[Authorize()]
        //// GET api/verbamarketing
        //public HttpResponseMessage Get(int id, string tk)
        //{
        //    try
        //    {
              
        //        if (id == 0)
        //            return Request.CreateResponse(HttpStatusCode.OK, new BE.SolicitacaoVerba() { StatusID = "E" });

        //        BE.SolicitacaoVerba a = VerbaMarketingBC.PlanoEstrategico.GetPLano(VerbaMarketingBC.SolicitacaoVerba.GetItem(new BE.SolicitacaoVerba() { ID = id, Token = tk }).FirstOrDefault());
             
        //        return Request.CreateResponse(HttpStatusCode.OK,a);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError,   this.ActionContext.Request.RequestUri.ToString() +  VerbaUtil.Util.GetAllError(ex)  );
        //    }
        //}

        //[HttpPost()]
        //[Route("api/verbamarketing/GetList")]
        ////[Authorize()]
        //// GET api/verbamarketing
        //public HttpResponseMessage GetList([FromBody]BE.SolicitacaoVerba verba)
        //{
        //    try
        //    {
        //        return Request.CreateResponse(HttpStatusCode.OK, VerbaMarketingBC.SolicitacaoVerba.GetList(verba));
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError,  VerbaUtil.Util.GetAllError(ex) );
        //    }
        //}

      
        //[HttpGet()]
        //[Route("api/verbamarketing/Rel/{iDreg}/{login}/{statusID}/{setorial}/{planejadoSumario}/{areaSolicitanteid}/{idsprodutos}/{dataIniciostr}/{dataFimstr}/{idsobjetivos}/{statusc}/{valor1}/{valor2}")]
        ////[Authorize()]
        //// GET api/verbamarketing
        //public HttpResponseMessage Rel(string iDreg, string login,string statusID,string setorial,string planejadoSumario,
        //    string areaSolicitanteid,string idsprodutos,string dataIniciostr,string dataFimstr,string idsobjetivos, string statusc,string valor1,string valor2)
        //{
        //    try
        //    {
        //         List<BE.Produto> prods = null;
        //         List<BE.ObjetivoEstrategico> objs = null;
        //         List<BE.DetalhamentoInvestimento> invs = null;

        //         if (idsprodutos != "null") {
        //            idsprodutos= idsprodutos.Remove(idsprodutos.Length-1);
        //             prods = new List<BE.Produto>(); idsprodutos.Split(',').ToList().ForEach(fe => prods.Add(new BE.Produto() { ID = fe }));
        //         }
        //         if (idsobjetivos != "null") {
        //           idsobjetivos=  idsobjetivos.Remove(idsobjetivos.Length-1);
        //             objs = new List<BE.ObjetivoEstrategico>(); idsobjetivos.Split(',').ToList().ForEach(fe => objs.Add(new BE.ObjetivoEstrategico() { ID = int.Parse(fe) }));
        //         }
        //         if (valor1 != "null" && valor2 != "null")
        //         {
        //             invs = new List<BE.DetalhamentoInvestimento>(); invs.Add(new BE.DetalhamentoInvestimento() { Valor = decimal.Parse(valor1) }); invs.Add(new BE.DetalhamentoInvestimento() { Valor = decimal.Parse(valor2) });
        //         }

        //         BE.SolicitacaoVerba verba = new BE.SolicitacaoVerba()
        //         {
        //             IDreg = iDreg != "null"?iDreg:null,
        //             Responsavel = login != "null"?  new BE.Pessoa() { Login = login }: null,
        //              StatusID = statusID!= "null"? statusID:null ,
        //             Statusc = statusc != "null" ? statusc : null,
        //             Setorial = setorial!= "null"? bool.Parse(setorial):false,
        //             PlanejadoSumario = planejadoSumario!= "null"? bool.Parse(planejadoSumario):false,
        //                                                                AreaSolicitante = areaSolicitanteid!= "null"? new BE.Area() { ID = areaSolicitanteid }:null,
        //                                                                Produtos = prods,
        //                                                                DataIniciostr = dataIniciostr!= "null"?dataIniciostr.Replace("-","/"):null,
        //             DataFimstr = dataFimstr != "null" ? dataFimstr.Replace("-", "/") : null,
        //                                                                Objetivos = objs,
        //                                                                DetalhamentosInvestimentos = invs
        //        };
        //        HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.OK);

        //        StringBuilder header = new StringBuilder();
        //        header =  GetExcel(verba, header);

        //        result.Content = new StringContent(header.ToString(), Encoding.Unicode);
        //        result.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
        //        result.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment"); //attachment will force download
        //        result.Content.Headers.ContentDisposition.FileName = "RecordExport.xls";

        //        return result;
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError, VerbaUtil.Util.GetAllError(ex));
        //    }
        //}



        //private static StringBuilder GetExcel(BE.SolicitacaoVerba verba, StringBuilder header)
        //{
        //    header.Append("Número da solicitação" + "\t");
        //    header.Append("Evento ou Ação" + "\t");
        //    header.Append("Setorial " + "\t");
        //    header.Append("Planejado no Sumário " + "\t");
        //    header.Append("Área" + "\t");
        //    header.Append("Entidade" + "\t");
        //    header.Append("Centro de Custo" + "\t");
        //    header.Append("Item Contábil" + "\t");
        //    header.Append("Classe de valor" + "\t");
        //    header.Append("Produtos" + "\t");
        //    header.Append("Data Início " + "\t");
        //    header.Append("Data Fim " + "\t");
        //    header.Append("Descrição do Cenário" + "\t");
        //    header.Append("Justificativa" + "\t");
        //    header.Append("Programação" + "\t");
        //    header.Append("Perfil do Público Alvo" + "\t");
            
        //    header.Append("Objetivo Estratégico " + "\t");
        //    header.Append("Detalhes do Investimento" + "\t");
        //    header.Append("Meta" + "\t");
        //    header.Append("Expectativa de Retorno" + "\t");
        //    header.Append("ROI" + "\t");
            
        //    header.Append("Prazo Previsto de Mensuração" + Environment.NewLine);

        //    foreach (var item in VerbaMarketingBC.SolicitacaoVerba.GetRel(verba))
        //    {
        //        header.AppendFormat(item.IDreg + "\t");
        //        header.AppendFormat(((item.MyEstrategiaAtuacao.ToString() == "E")?"Evento":"Ação") + "\t");
        //        header.AppendFormat(((item.Setorial)?"Sim":"Não") + "\t");
        //        header.AppendFormat(((item.PlanejadoSumario) ? "Sim" : "Não") + "\t");
        //        header.AppendFormat((item.AreaSolicitante.ID.Trim() + item.AreaSolicitante.Nome) + "\t");
        //        header.AppendFormat( item.Entidade.Nome + "\t");
        //        header.AppendFormat((item.CentroCusto.ID.Trim()+"-"+item.CentroCusto.Nome) + "\t");
        //        header.AppendFormat(item.Subconta1.Nome.Replace("  ", "") + "\t");
        //        header.AppendFormat(item.Subconta2.Nome.Replace("  ", "") + "\t");
        //        header.AppendFormat(Prods(item.Produtos) + "\t");
        //        header.AppendFormat(item.DataIniciostr + "\t");
        //        header.AppendFormat(item.DataFimstr + "\t");
        //        header.AppendFormat(item.DescricaoCenario + "\t");
        //        header.AppendFormat(item.Justificativa + "\t");
        //        header.AppendFormat(item.DescProg + "\t");
        //        header.AppendFormat(item.PerfilPublicoAlvo + "\t");
        //        header.AppendFormat(Objst(item.Objetivos) + "\t");
        //        header.AppendFormat(Det(item.DetalhamentosInvestimentos) + "\t");
        //        header.AppendFormat(item.Meta + "\t");
        //        header.AppendFormat(item.EspectativaRetorno + "\t");
        //        header.AppendFormat(item.ROI + "\t");
                
        //        header.AppendFormat(item.Prazo + Environment.NewLine);
        //    }

        //    return header;
        //}

        //private static string Det(List<BE.DetalhamentoInvestimento> list)
        //{
        //    string prosd = "";
        //    list.ForEach(fe => prosd += fe.Recurso + ":" + DoFormat(fe.Valor) + "|");
        //    return prosd;
        //}

        //private static string DoFormat(decimal myNumber)
        //{
        //    var s = string.Format("{0:0.00}", myNumber);

        //    if (s.EndsWith("00"))
        //    {
        //        return ((int)myNumber).ToString();
        //    }
        //    else
        //    {
        //        return s;
        //    }
        //}

        //private static string Objst(List<BE.ObjetivoEstrategico> list)
        //{
        //    string prosd = "";
        //    list.ForEach(fe => prosd += fe.Nome + ";");
        //    return prosd;
        //}

        //private static string Prods(List<BE.Produto> list)
        //{
        //    string prosd= "";
        //    list.ForEach(fe => prosd += fe.Nome + ";");
        //    return prosd;
        //}


        //[HttpPost()]
        //[Route("api/verbamarketing/Insert")]
        //[Authorize()]
        //// GET api/verbamarketing
        //public HttpResponseMessage Insert([FromBody]BE.SolicitacaoVerba verba)
        //{
        //    try
        //    {
        //        if (!string.IsNullOrEmpty(Validacao(verba)))
        //            throw new Exception(Validacao(verba));

        //        int idoriginal = verba.ID;
               
        //      //  using (TransactionScope scope = new TransactionScope())
        //      //  {
        //            verba = VerbaMarketingBC.SolicitacaoVerba.Insert(verba);
        //           // int idfixo = verba.ID;
        //            //if (idoriginal == 0) 
        //               // verba.ID = idoriginal;

        //            SendToCusto(verba, idoriginal);
                    

        //      //      scope.Complete();
                      
        //              return Request.CreateResponse(HttpStatusCode.OK, verba);
                   
        //     //   }
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError,  VerbaUtil.Util.GetAllError(ex) );
        //    }
        //}


        // [HttpGet()]
        // [Authorize()]
        // [Route("api/verbamarketing/RemoveVerba/{id}")]
        //public HttpResponseMessage RemoveVerba(int id)
        //{
        //    try
        //    {
        //        VerbaMarketingBC.SolicitacaoVerba.RemoveVerba(id);
        //        return Request.CreateResponse(HttpStatusCode.OK, VerbaMarketingBC.SolicitacaoVerba.GetList(new BE.SolicitacaoVerba() { StatusID = "0" }));
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError, VerbaUtil.Util.GetAllError(ex));
        //    }
        //}

       

        //[HttpPost()]
        //[Route("api/verbamarketing/Aprovacao")]
        ////[Authorize()]
        //// GET api/verbamarketing
        //public HttpResponseMessage Aprovacao([FromBody]BE.Aprovacao apv)
        //{
        //    try
        //    {
        //      //  using (TransactionScope scope = new TransactionScope())
        //       // {
        //            VerbaMarketingBC.SolicitacaoVerba.Aprovacao(apv);
        //            if (apv.Aprovado)//envia email para a aprovação de comunicação e para solicitante
        //            {
        //                SendToSolicitante_ComunicacaoAp(apv);
        //            }
        //            else
        //            {//envia email para solicitante informando a reprovação
        //                SendToSolicitante_ComunicacaoRp(apv);
        //            }
        //      //      scope.Complete();
        //     //   }
        //        return Request.CreateResponse(HttpStatusCode.OK, true);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError,  VerbaUtil.Util.GetAllError(ex) );
        //    }
        //}

       

        //[HttpPost()]
        //[Route("api/verbamarketing/AprovacaoC")]
        ////[Authorize()]
        //// GET api/verbamarketing
        //public HttpResponseMessage AprovacaoC([FromBody]BE.Aprovacao apv)
        //{
        //    try
        //    {
        //       // using (TransactionScope scope = new TransactionScope())
        //       // {
        //            VerbaMarketingBC.SolicitacaoVerba.AprovacaoC(apv);
        //            if (apv.Aprovado)//envia email para a aprovação de comunicação e para solicitante
        //            {
        //                SendToSolicitante_ComunicacaoAPC(apv);
        //            }
        //            else
        //            {//envia email para solicitante informando a reprovação comunicação
        //                SendToSolicitante_ComunicacaoRPC(apv);
        //            }
        //    //        scope.Complete();
        //    //    }
        //        return Request.CreateResponse(HttpStatusCode.OK, true);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError,  VerbaUtil.Util.GetAllError(ex) );
        //    }
        //}

      
        //[HttpGet()]
        //[Route("api/verbamarketing/GetUser")]
        //[Authorize()]
        //// GET api/verbamarketing
        //public HttpResponseMessage GetUser()
        //{
        //    try
        //    {
               
        //        return Request.CreateResponse(HttpStatusCode.OK, VerbaMarketingBC.Pessoa.GetItem(new BE.Pessoa()
        //        {
        //            ID = int.Parse(this.User.Identity.Name.ToString()),
        //            IsAdmin = this.User.IsInRole("Admin")
        //        }));
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError,  VerbaUtil.Util.GetAllError(ex) );
        //    }
        //}

        //[HttpGet()]
        //[Route("api/usuario/FindLgs/{lg}")]

        //// GET api/verbamarketing
        //public HttpResponseMessage FindLgs(string lg)
        //{
        //    try
        //    {
        //        return Request.CreateResponse(HttpStatusCode.OK, VerbaMarketingBC.SolicitacaoVerba.FindLgs(lg));

        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError,  VerbaUtil.Util.GetAllError(ex) );
        //    }
        //}

        //// POST api/verbamarketing
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/verbamarketing/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/verbamarketing/5
        //public void Delete(int id)
        //{
        //}

        //#region Privates

        //private string Validacao(BE.SolicitacaoVerba verba)
        //{
        //    string msg = string.Empty;
        //    if (verba.DataInicio > verba.DataFim)
        //       msg += "A Data Inicial não pode ser maior que a Data Final. \n";

        //    if (verba.Prazo < DateTime.Now)
        //        msg += "O Prazo tem que ser maior que a data de hoje. \n";

        //    return msg;
        //}
        //private void SendToCusto(BE.SolicitacaoVerba verba, int idoriginal)
        //{
        //    string msg = "";
        //    msg += "<p>Foi " + (idoriginal == 0 ? "criada" : "alterada") + " uma solicitação para Ação de Mercado e Vendas nº " + verba.IDreg + " para o centro de custo " + verba.CentroCusto.Nome + ".</p>";
        //    msg += "<p>Clique <a href='" + URL + "#/AprovacaoSolicitacaoVerba/" + verba.ID + "/" + verba.Token + "'>aqui</a> para analisar a solicitação.";
        //    msg += "</p>";
        //    using (EmailRef.WSEmailSoapClient email = new EmailRef.WSEmailSoapClient())
        //    {
        //       // email.sendEmailToAddress2(verba.CentroCusto.Gestor.Email, verba.Responsavel.Email, BE.SolicitacaoVerba.TituloSolicitacao, msg, true);
        //        email.sendEmailToAddress2("CMGOMES@firjan.com.br", verba.Responsavel.Email, BE.SolicitacaoVerba.TituloSolicitacao, msg, true);
        //    }
        //}

        //private void SendToSolicitante_ComunicacaoAp(BE.Aprovacao apv)
        //{
        //    string msg = "";
        //    msg += "<p>Sua Solicitação para Ação de Mercado e Vendas nº " + apv.Verba.IDreg + " foi aprovada.</p>";
        //    msg += "<p>Empresa: " + apv.Verba.Entidade.Nome + ".</p>";
        //    msg += "<p> Centro de Custo: " + apv.Verba.CentroCusto.Nome + ".</p>";
        //    msg += "<p> Item Contabil: " + apv.Verba.Subconta1.Nome + ".</p>";
        //    msg += "<p> Classe de Valor: " + apv.Verba.Subconta2.Nome + ".</p>";
        //    msg += "<p> Data : " + apv.Verba.DataIniciostr + " a " + apv.Verba.DataFimstr + ".</p>";
        //    msg += "<p> Objetivos estratégicos : </p>";
        //    foreach (var item in apv.Verba.Objetivos)
        //    {
        //        msg += "<p> _" + item.Nome + ". </p>";
                
        //    }
        //    msg += "<p> Investimento: " + apv.Verba.DetalhamentosInvestimentos.Sum(u=> u.Valor) + ".</p>";
        //    //add todos os campos de cobrança
        //    if (apv.Verba.NecessitaApoio)
        //    {
        //        msg += "<p>Foi encaminhado ao responsável solicidado o email para aprovação da verba de comunicação.</p>";
        //    }

        //    string msg1 = "";
        //    msg1 += "<p>Foi aberta uma solicitação de Apoio de Comunicação.</p>";
        //    msg1 += "<p>Clique <a href='" + URL + "#/AprovacaoComunicacao/" + apv.Verba.ID + "/" + apv.Verba.Token + "'>aqui</a> para analisar a solicitação.";
        //    msg1 += "</p>";

        //    using (EmailRef.WSEmailSoapClient email = new EmailRef.WSEmailSoapClient())
        //    {
        //        email.sendEmailToAddress2(apv.Verba.Responsavel.Email, BE.SolicitacaoVerba.EmailSistema, BE.SolicitacaoVerba.TituloSolicitacao, msg, true);
        //        if (apv.Verba.NecessitaApoio)
        //            email.sendEmailToAddress2(apv.Verba.UsuarioAporvador.Email, apv.Verba.Responsavel.Email, BE.SolicitacaoVerba.TituloSolicitacaoComun, msg1, true);
        //    }
        //}

        //private void SendToSolicitante_ComunicacaoRp(BE.Aprovacao apv)
        //{
        //    string msg = "";
        //    msg += "<p>Sua solicitação para Ação de Mercado e Vendas  nº " + apv.Verba.IDreg + " não foi aprovada. Motivo: " + apv.Txtmsgenvio + "</p>";
        //   // msg += "<p>Clique <a href='" + URL + "#/SolicitacaoVerba/" + apv.Verba.ID + "/" + apv.Verba.Token + "'>aqui</a> para analisar a solicitação.";
        //    msg += "</p>";

        //    using (EmailRef.WSEmailSoapClient email = new EmailRef.WSEmailSoapClient())
        //    {
        //        email.sendEmailToAddress2(apv.Verba.Responsavel.Email, BE.SolicitacaoVerba.EmailSistema, BE.SolicitacaoVerba.TituloSolicitacao, msg, true);
              
        //    }
        //}

        //private void SendToSolicitante_ComunicacaoRPC(BE.Aprovacao apv)
        //{
        //    string msg = "";
        //    msg += "<p>Sua solicitação para comunicação da verba nº " + apv.Verba.IDreg + " não foi aprovada. Motivo: " + apv.Txtmsgenvio + "</p>";
        //   // msg += "<p>Clique <a href='" + URL + "#/SolicitacaoVerba/" + apv.Verba.ID + "/" + apv.Verba.Token + "'>aqui</a> para analisar a solicitação.";
        //    msg += "</p>";

        //    using (EmailRef.WSEmailSoapClient email = new EmailRef.WSEmailSoapClient())
        //    {
        //        email.sendEmailToAddress2(apv.Verba.Responsavel.Email, BE.SolicitacaoVerba.EmailSistema, BE.SolicitacaoVerba.TituloSolicitacao, msg, true);

        //    }
        //}

        //private void SendToSolicitante_ComunicacaoAPC(BE.Aprovacao apv)
        //{
        //    string msg = "";
        //    msg += "<p>Sua solicitação para comunicação foi aprovada.</p>";
        //    msg += !string.IsNullOrEmpty(apv.Txtmsgenvio) ?("<br>obs: "+ apv.Txtmsgenvio +"<br>") : "";
        //   // msg += "<p>Clique <a href='" + URL + "#/SolicitacaoVerba/" + apv.Verba.ID + "/" + apv.Verba.Token + "'>aqui</a> para analisar a solicitação.";
        //    msg += "</p>";

        //    using (EmailRef.WSEmailSoapClient email = new EmailRef.WSEmailSoapClient())
        //    {
        //        email.sendEmailToAddress2(apv.Verba.Responsavel.Email, BE.SolicitacaoVerba.EmailSistema, BE.SolicitacaoVerba.TituloSolicitacao, msg, true);
               
        //    }
        //}

        //private string URL { get { return ConfigurationManager.AppSettings["urlSite"].ToString(); } set { } }
        //#endregion
    }
}
