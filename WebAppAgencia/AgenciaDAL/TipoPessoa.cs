using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaModel;

namespace AgenciaDAL
{
   public class TipoPessoa : GenericDAL<AgenciaModel.TipoPessoa>
    {

        private AgenciaModel.TipoPessoa pessoaCurrent;
        Contexto cx = new Contexto();

        public override AgenciaModel.TipoPessoa Salva(AgenciaModel.TipoPessoa dados)
        {
            return base.Salva(dados);
        }

        public override AgenciaModel.TipoPessoa Update(AgenciaModel.TipoPessoa dados)
        {
            return base.Update(dados);
        }


        public override void Delete(AgenciaModel.TipoPessoa dados, int id)
        {
            base.Delete(dados, id);
        }


        public dynamic Lista(AgenciaModel.TipoPessoa pessoa)
        {
           var query = cx.TipoPessoas.AsQueryable();
           

            return query.Select(s=> new
            {

                s.Id,
                s.Nome,
                s.Visivel

            });
        }

        public AgenciaModel.TipoPessoa Get(int Id)
        {
            return cx.TipoPessoas.Find(Id);
        }



    }
}
