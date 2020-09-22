using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaModel;

namespace AgenciaDAL
{
   public class Contato : GenericDAL<AgenciaModel.Contato>
    {

    
        Contexto cx = new Contexto();

        public override AgenciaModel.Contato Salva(AgenciaModel.Contato dados)
        {
            return base.Salva(dados);
        }

        public override AgenciaModel.Contato Update(AgenciaModel.Contato dados)
        {
            return base.Update(dados);
        }


        public override void Delete(AgenciaModel.Contato dados, int id)
        {
            base.Delete(dados, id);
        }


        public dynamic Lista(AgenciaModel.Contato pessoa)
        {
            return null;
        }

        public AgenciaModel.Pessoa Get(int Id)
        {
            return cx.Pessoas.Find(Id);
        }



    }
}
