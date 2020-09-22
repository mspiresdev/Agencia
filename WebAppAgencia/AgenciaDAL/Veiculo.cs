using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaModel;

namespace AgenciaDAL
{
   public class Veiculo : GenericDAL<AgenciaModel.Veiculo>
    {

    
        Contexto cx = new Contexto();

        public override AgenciaModel.Veiculo Salva(AgenciaModel.Veiculo dados)
        {
            return base.Salva(dados);
        }

        public override AgenciaModel.Veiculo Update(AgenciaModel.Veiculo dados)
        {
            return base.Update(dados);
        }


        public override void Delete(AgenciaModel.Veiculo dados, int id)
        {
            base.Delete(dados, id);
        }


        public dynamic Lista(AgenciaModel.Veiculo pessoa)
        {
            return null;
        }

        public AgenciaModel.Veiculo Get(int Id)
        {
            return cx.Veiculos.Find(Id);
        }



    }
}
