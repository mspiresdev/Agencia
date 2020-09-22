using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaModel;

namespace AgenciaDAL
{
   public class Servico : GenericDAL<AgenciaModel.Servico>
    {

        private AgenciaModel.Servico pessoaCurrent;

        public override AgenciaModel.Servico Salva(AgenciaModel.Servico dados)
        {
            return base.Salva(dados);
        }

        public override AgenciaModel.Servico Update(AgenciaModel.Servico dados)
        {
            return base.Update(dados);
        }


        public override void Delete(AgenciaModel.Servico dados, int id)
        {
            base.Delete(dados, id);
        }


        public static List<AgenciaModel.Servico> Lista(AgenciaModel.Servico pessoa)
        {
            using (Contexto cx = new Contexto())
            {
                return cx.Servicos.ToList();
            }
        }


       
    }
}
