using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaModel;

namespace AgenciaDAL
{
   public class Pessoa: GenericDAL<AgenciaModel.Pessoa>
    {

        private AgenciaModel.Pessoa pessoaCurrent;
        Contexto cx = new Contexto();

        public override AgenciaModel.Pessoa Salva(AgenciaModel.Pessoa dados)
        {
            return base.Salva(dados);
        }

        public override AgenciaModel.Pessoa Update(AgenciaModel.Pessoa dados)
        {
            UpdateChilds(dados);
            return base.Update(dados);
        }

        private static void UpdateChilds(AgenciaModel.Pessoa dados)
        {
            Contato contatoDal = new Contato();

            foreach (var item in dados.Contatos)
            {
                if (item.Pessoa_Id != null)//update
                    contatoDal.Update(item);
                else
                {
                    item.Pessoa_Id = dados.Id;
                    contatoDal.Salva(item);
                }

            }

            Endereco enderecoDal = new Endereco();

            foreach (var item in dados.Enderecos)
            {
                if (item.Pessoa_Id != null)//update
                    enderecoDal.Update(item);
                else
                {
                    item.Pessoa_Id = dados.Id;
                    enderecoDal.Salva(item);
                }

            }

            Veiculo veiculoDal = new Veiculo();

            foreach (var item in dados.Veiculos)
            {
                if (item.Pessoa_Id != null)//update
                    veiculoDal.Update(item);
                else
                {
                    item.Pessoa_Id = dados.Id;
                    veiculoDal.Salva(item);
                }

            }
        }

        public AgenciaModel.Usuario AcessoUsuario(string userName, string password)
        {
             return cx.Pessoas.Where(u => u.Usuario.Usu == userName && u.Usuario.Senha == password).Select(s => s.Usuario).FirstOrDefault();
        }

        public override void Delete(AgenciaModel.Pessoa dados, int id)
        {
            base.Delete(dados, id);
        }


        public dynamic Lista(AgenciaModel.Pessoa pessoa)
        {
           var query = cx.Pessoas.Where(u=> u.Visivel == true).AsQueryable();
            if (pessoa.TipoPessoa_Id != 0)
                query = query.Where(u => u.TipoPessoa_Id == pessoa.TipoPessoa_Id);

            if(!string.IsNullOrEmpty(pessoa.Nome))
                query = query.Where(u => u.Nome.Contains(pessoa.Nome));

            if (!string.IsNullOrEmpty(pessoa.CPF))
                query = query.Where(u => u.CPF == pessoa.CPF);

            if (!string.IsNullOrEmpty(pessoa.CNPJ))
                query = query.Where(u => u.CNPJ == pessoa.CNPJ);

            return query.Select(s=> new {

                 s.Id,
                 s.Nome,
                 s.CNPJ,
                 s.CPF,
                 s.CNH,
                 s.Visivel,
                 s.TipoPessoa_Id,
                 s.TipoPessoa
                
                
            });
        }

        public AgenciaModel.Pessoa Get(int Id)
        {
            if (Id == 0)
                return cx.Pessoas.OrderByDescending(u => u.Id).FirstOrDefault();

            return cx.Pessoas.Find(Id);
        }



    }
}
