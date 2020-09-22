using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaModel;

namespace AgenciaDAL
{
   public class MaterialServico : GenericDAL<AgenciaModel.MaterialServico>
    {

        private AgenciaModel.Servico pessoaCurrent;

        public override AgenciaModel.MaterialServico Salva(AgenciaModel.MaterialServico dados)
        {
            return base.Salva(dados);
        }

        public override AgenciaModel.MaterialServico Update(AgenciaModel.MaterialServico dados)
        {
            return base.Update(dados);
        }


        public override void Delete(AgenciaModel.MaterialServico dados, int id)
        {
            base.Delete(dados, id);
        }


        public static List<AgenciaModel.MaterialServico> Lista(AgenciaModel.MaterialServico pessoa)
        {
            using (Contexto cx = new Contexto())
            {
                return cx.MaterialServicos.ToList();
            }
        }


       
    }
}
