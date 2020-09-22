using AgenciaModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDAL
{
    public class Contexto : DbContext
    {

        protected override void OnModelCreating(DbModelBuilder mb)
        {
            this.Database.CommandTimeout = 5;

            // Remove a plural automatico
            mb.Conventions
                .Remove<PluralizingTableNameConvention>();

            // Remove o cascatting delete automatico
            mb.Conventions
                .Remove<OneToManyCascadeDeleteConvention>();



            PessoaRelacionamento.Do(mb);

            ReservaRelacionamento.Do(mb);

        }
        public DbSet<AgenciaModel.Pessoa> Pessoas { get; set; }

        public DbSet<AgenciaModel.Usuario> Usuarios { get; set; }

        public DbSet<AgenciaModel.TipoPessoa> TipoPessoas { get; set; }

        public DbSet<AgenciaModel.Contato> Contatos { get; set; }

        public DbSet<AgenciaModel.Endereco> Enderecos { get; set; }

        public DbSet<AgenciaModel.Veiculo> Veiculos { get; set; }

        public DbSet<AgenciaModel.Reserva> Reservas { get; set; }

        public DbSet<AgenciaModel.Itinerario> Itinerarios { get; set; }

        public DbSet<AgenciaModel.Servico> Servicos { get; set; }

        public DbSet<AgenciaModel.MaterialServico> MaterialServicos{ get; set; }
        public Contexto() : base("name=CtsContext")
        {

        }
    }
}
