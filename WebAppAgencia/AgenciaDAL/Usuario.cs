using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaModel;

namespace AgenciaDAL
{
   public class Usuario : GenericDAL<AgenciaModel.Usuario>
    {

        private AgenciaModel.Usuario pessoaCurrent;
        Contexto cx = new Contexto();

        public override AgenciaModel.Usuario Salva(AgenciaModel.Usuario dados)
        {
            return base.Salva(dados);
        }

        public override AgenciaModel.Usuario Update(AgenciaModel.Usuario dados)
        {
            return base.Update(dados);
        }


        public override void Delete(AgenciaModel.Usuario dados, int id)
        {
            base.Delete(dados, id);
        }


        public dynamic Lista(AgenciaModel.Usuario pessoa)
        {
           var query = cx.Pessoas.AsQueryable();
           

            return query.Select(s=> new
            {

                s.Id,
                s.Nome,
                s.Visivel

            });
        }
        public int LastId()
        {
           return cx.Usuarios.OrderByDescending(u => u.Id).FirstOrDefault().Id;
        }
        public AgenciaModel.Usuario Get(int Id)
        {
            return cx.Pessoas.Find(Id).Usuario;
        }



    }
}
