using Microsoft.VisualStudio.TestTools.UnitTesting;
using AgenciaDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDAL.Tests
{
    [TestClass()]

   
    public class PessoaTests
    {
        AgenciaDAL.Pessoa p = new Pessoa();

        [TestMethod()]
        public void InsertPessoa()
        {
         
          
            
           //// p.Update(new AgenciaModel.Pessoa() { Id=1 , Nome = "marcos atualizado", CNPJ = "2453534646", Juridica = false, UltimaAtualizacao = DateTime.Now, Registro = DateTime.Now });
           // p.Salva(new AgenciaModel.Pessoa() { Nome = "marcos ", CNPJ = "2453534646", Juridica = false, UltimaAtualizacao = DateTime.Now, Registro = DateTime.Now,  Contatos = new List<AgenciaModel.Contato> {
           //     new AgenciaModel.Contato() {  Numero = "33421062", Tipo="Residencial", Descricao = "Tel", Registro =DateTime.Now, UltimaAtualizacao = DateTime.Now} }  });
           // var a = p.Lista(new AgenciaModel.Pessoa() { });
           // Assert.IsFalse(a.Count() <= 0);
        }

        [TestMethod()]
        public void ListarPessoa()
        {
            //var a = p.Lista(new AgenciaModel.Pessoa() { });
            //Assert.IsFalse(a.Count() <= 0);
        }
    }
}