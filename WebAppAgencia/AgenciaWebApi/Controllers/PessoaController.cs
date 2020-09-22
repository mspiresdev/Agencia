using AgenciaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AgenciaWebApi.Controllers
{
    public class PessoaController : ApiController
    {
        // GET: api/Pessoa
        AgenciaDAL.Pessoa Dal = new AgenciaDAL.Pessoa();
        AgenciaDAL.Usuario uDal = new AgenciaDAL.Usuario();
        // GET: api/Pessoa
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Pessoa/5
        
        public AgenciaModel.Pessoa Get(int id)
        {
            if (id == 0)
                return new AgenciaModel.Pessoa() { Juridica = false };

            return Dal.Get(id);

        }

        // POST: api/Pessoa

        public dynamic Post(AgenciaModel.Pessoa value)
        {
            return Dal.Lista(value);
        }

        // PUT: api/Pessoa/5
        public void Put(AgenciaModel.Pessoa value)
        {
            if (value.Id != 0)
            {
                if (value.Usuario != null)
                {
                    if (value.Usuario_Id.HasValue)
                        uDal.Update(value.Usuario);
                    else
                    {
                        value.Usuario.Pessoa_Id = value.Id;
                        uDal.Salva(value.Usuario);
                        value.Usuario_Id = uDal.LastId();
                    }
                }
                Dal.Update(value);//atualiza pessoa
            }
            else
            {
                Usuario usu = null;
                Pessoa pess = null;
                bool valid = true;
                foreach (var item in Dal.Lista(value)) { valid = false; }
                if (valid)
                {

                    if (value.Usuario != null)
                    { usu = value.Usuario; value.Usuario = null; }
                    Dal.Salva(value);
                    pess = Dal.Get(0);
                    pess.Usuario = usu;
                    Put(pess);
                }
                else
                    throw new Exception(string.IsNullOrEmpty(value.CPF) ? "CNPJ já existe na base" : "CPF já existe na base");
            }
        }

        // DELETE: api/Pessoa/5
        public void Delete(int id)
        {
        }
    }
}
