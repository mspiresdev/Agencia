using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaModel
{
    public static class PessoaRelacionamento
    {
        public static void Do(DbModelBuilder mb)
        {


            mb.Entity<Contato>()
            .HasRequired(pc => pc.Pessoa)
            .WithMany(p => p.Contatos)
            .HasForeignKey(pc => pc.Pessoa_Id);

            mb.Entity<Endereco>()
           .HasRequired(pc => pc.Pessoa)
           .WithMany(p => p.Enderecos)
           .HasForeignKey(pc => pc.Pessoa_Id);

            mb.Entity<Veiculo>()
          .HasRequired(pc => pc.Pessoa)
          .WithMany(p => p.Veiculos)
          .HasForeignKey(pc => pc.Pessoa_Id);




            mb.Entity<Pessoa>()
           .HasRequired(s=> s.TipoPessoa)
           .WithMany()
           .HasForeignKey(u => u.TipoPessoa_Id);


            mb.Entity<Pessoa>()
             .HasMany(c => c.Contatos)
             .WithRequired()
             .HasForeignKey(e => e.Pessoa_Id);

         


        

            mb.Entity<Pessoa>()
            .HasMany(c => c.Enderecos)
            .WithRequired()
            .HasForeignKey(e => e.Pessoa_Id);

            mb.Entity<Pessoa>()
             .HasMany(c => c.Veiculos)
             .WithRequired()
             .HasForeignKey(e => e.Pessoa_Id);


            //mb.Entity<Pessoa>()
            //  .HasOptional(s => s.PessoaEmp)
            //  .WithMany(s => s.Colaboradores)
            //  .HasForeignKey(s => s.PessoaEmp_Id);




            mb.Entity<Pessoa>()
            .HasOptional(s => s.Usuario)
                .WithMany()
               .HasForeignKey(u => u.Usuario_Id);

            mb.Entity<Usuario>()
               .HasRequired(u => u.Pessoa)
               .WithMany()
               .HasForeignKey(u => u.Pessoa_Id);

            mb.Entity<Perfil>()
             .HasRequired(pc => pc.Usuario)
             .WithMany(p => p.Perfis)
             .HasForeignKey(pc => pc.Usuario_Id);

            mb.Entity<Usuario>()
             .HasMany(c => c.Perfis)
             .WithRequired()
             .HasForeignKey(e => e.Usuario_Id);

        }   


    }
}
