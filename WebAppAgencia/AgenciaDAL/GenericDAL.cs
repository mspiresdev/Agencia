using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDAL 
{
    public class GenericDAL<Tipo> where Tipo : class
    {
        protected Tipo antes { get; private set; }
        protected Tipo alteracoes { get; private set; }
        protected Tipo depois { get; private set; }
        protected DbSet<Tipo> dbSet { get; private set; }

       

        //public virtual dynamic Lista(Tipo filtros)
        //{
        //    return null;
        //}

        public virtual Tipo Salva(Tipo dados) 
        {
            using (Contexto cx = new Contexto())
            {
                cx.Set<Tipo>().Add(dados);
                cx.SaveChanges();
            }
            return dados;
        }
        public virtual Tipo Update(Tipo dados)
        {
            using (Contexto cx = new Contexto())
            {
                cx.Set<Tipo>().Attach(dados);
                cx.Entry(dados).State = EntityState.Modified;
                cx.SaveChanges();
            }
            return dados;
        }

        public virtual void Delete(Tipo dados, int id)
        {

            using (Contexto cx = new Contexto())
            {
                DbSet<Tipo> dbSet = cx.Set<Tipo>();
                Tipo entity = dbSet.Find(id);
                dbSet.Attach(entity);
                dbSet.Remove(entity);

            }

        }

    }
}
