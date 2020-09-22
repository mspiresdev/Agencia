namespace AgenciaDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReservaServico",
                c => new
                    {
                        Reserva_Id = c.Int(nullable: false),
                        Servico_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Reserva_Id, t.Servico_Id })
                .ForeignKey("dbo.Reserva", t => t.Reserva_Id)
                .ForeignKey("dbo.Servico", t => t.Servico_Id)
                .Index(t => t.Reserva_Id)
                .Index(t => t.Servico_Id);
            
            CreateTable(
                "dbo.Servico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        ValorPadrao = c.Double(),
                        Custo = c.Double(),
                        Comissao = c.Double(),
                        Registro = c.DateTime(nullable: false),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MaterialServico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        PessoaMaterial_Id = c.Int(),
                        Registro = c.DateTime(nullable: false),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                        PessoaMaterial_Id1 = c.Int(),
                        Servico_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.PessoaMaterial_Id1)
                .ForeignKey("dbo.Servico", t => t.Servico_Id)
                .Index(t => t.PessoaMaterial_Id1)
                .Index(t => t.Servico_Id);
            
            AddColumn("dbo.Contato", "Registro", c => c.DateTime(nullable: false));
            AddColumn("dbo.Contato", "UltimaAtualizacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pessoa", "Registro", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pessoa", "UltimaAtualizacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Endereco", "Registro", c => c.DateTime(nullable: false));
            AddColumn("dbo.Endereco", "UltimaAtualizacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Reserva", "NoVoo", c => c.String());
            AddColumn("dbo.Reserva", "Inicio", c => c.DateTime());
            AddColumn("dbo.Reserva", "Fim", c => c.DateTime());
            AddColumn("dbo.Reserva", "Custo", c => c.Double());
            AddColumn("dbo.Reserva", "Comissao", c => c.Double());
            AddColumn("dbo.Reserva", "Registro", c => c.DateTime(nullable: false));
            AddColumn("dbo.Reserva", "UltimaAtualizacao", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReservaServico", "Servico_Id", "dbo.Servico");
            DropForeignKey("dbo.MaterialServico", "Servico_Id", "dbo.Servico");
            DropForeignKey("dbo.MaterialServico", "PessoaMaterial_Id1", "dbo.Pessoa");
            DropForeignKey("dbo.ReservaServico", "Reserva_Id", "dbo.Reserva");
            DropIndex("dbo.MaterialServico", new[] { "Servico_Id" });
            DropIndex("dbo.MaterialServico", new[] { "PessoaMaterial_Id1" });
            DropIndex("dbo.ReservaServico", new[] { "Servico_Id" });
            DropIndex("dbo.ReservaServico", new[] { "Reserva_Id" });
            DropColumn("dbo.Reserva", "UltimaAtualizacao");
            DropColumn("dbo.Reserva", "Registro");
            DropColumn("dbo.Reserva", "Comissao");
            DropColumn("dbo.Reserva", "Custo");
            DropColumn("dbo.Reserva", "Fim");
            DropColumn("dbo.Reserva", "Inicio");
            DropColumn("dbo.Reserva", "NoVoo");
            DropColumn("dbo.Endereco", "UltimaAtualizacao");
            DropColumn("dbo.Endereco", "Registro");
            DropColumn("dbo.Pessoa", "UltimaAtualizacao");
            DropColumn("dbo.Pessoa", "Registro");
            DropColumn("dbo.Contato", "UltimaAtualizacao");
            DropColumn("dbo.Contato", "Registro");
            DropTable("dbo.MaterialServico");
            DropTable("dbo.Servico");
            DropTable("dbo.ReservaServico");
        }
    }
}
