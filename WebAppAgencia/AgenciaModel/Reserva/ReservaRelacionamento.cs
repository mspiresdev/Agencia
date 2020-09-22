using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaModel
{
    public static class ReservaRelacionamento
    {
        public static void Do(DbModelBuilder mb)
        {
            mb.Entity<Reserva>()
               .HasRequired(a => a.Cliente)
                .WithMany()
                .HasForeignKey(a => a.Cliente_Id);
            ;
            mb.Entity<Reserva>()
             .HasRequired(a => a.Fornecedor)
              .WithMany()
              .HasForeignKey(a => a.Fornecedor_Id);
            ;

            mb.Entity<Reserva>()
           .HasRequired(a => a.Agencia)
            .WithMany()
            .HasForeignKey(a => a.Agencia_Id);
            ;


            mb.Entity<Reserva>()
           .HasRequired(a => a.Origem)
            .WithMany()
            .HasForeignKey(a => a.Origem_Id);
            ;


            mb.Entity<Reserva>()
           .HasRequired(a => a.Destino)
            .WithMany()
            .HasForeignKey(a => a.Destino_Id);
            ;


            mb.Entity<ReservaServico>()
       .HasKey(k=> new { k.Reserva_Id, k.Servico_Id })
            ;

            mb.Entity<ReservaServico>()
            .HasRequired(s => s.Reserva)
            .WithMany(s => s.ReservaServicos)
             .HasForeignKey(a => a.Reserva_Id);
            ;

            mb.Entity<ReservaServico>()
         .HasRequired(s => s.Servico)
         .WithMany()
          .HasForeignKey(a => a.Servico_Id);
            ;
        }
    }
}
