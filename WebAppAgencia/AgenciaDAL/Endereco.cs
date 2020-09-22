using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaModel;

namespace AgenciaDAL
{
   public class Endereco : GenericDAL<AgenciaModel.Endereco>
    {

    
        Contexto cx = new Contexto();

        public override AgenciaModel.Endereco Salva(AgenciaModel.Endereco dados)
        {
            return base.Salva(dados);
        }

        public override AgenciaModel.Endereco Update(AgenciaModel.Endereco dados)
        {
            return base.Update(dados);
        }


        public override void Delete(AgenciaModel.Endereco dados, int id)
        {
            base.Delete(dados, id);
        }


        public dynamic Lista(AgenciaModel.Endereco pessoa)
        {
            return null;
        }

        public AgenciaModel.Endereco Get(int Id)
        {
            return cx.Enderecos.Find(Id);
        }



    }
}
