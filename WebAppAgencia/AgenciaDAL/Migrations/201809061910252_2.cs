namespace AgenciaDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contato",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pessoa_Id = c.Int(nullable: false),
                        Descricao = c.String(nullable: false),
                        Numero = c.String(nullable: false),
                        Tipo = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.Pessoa_Id)
                .Index(t => t.Pessoa_Id);
            
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pessoa_Id = c.Int(nullable: false),
                        Logradouro = c.String(nullable: false),
                        Numero = c.Int(nullable: false),
                        Complemento = c.String(),
                        Cep = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.Pessoa_Id)
                .Index(t => t.Pessoa_Id);
            
            CreateTable(
                "dbo.Reserva",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Cliente_Id = c.Int(nullable: false),
                        Agencia_Id = c.Int(nullable: false),
                        Fornecedor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.Agencia_Id)
                .ForeignKey("dbo.Pessoa", t => t.Cliente_Id)
                .ForeignKey("dbo.Pessoa", t => t.Fornecedor_Id)
                .Index(t => t.Cliente_Id)
                .Index(t => t.Agencia_Id)
                .Index(t => t.Fornecedor_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reserva", "Fornecedor_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Reserva", "Cliente_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Reserva", "Agencia_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Contato", "Pessoa_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Endereco", "Pessoa_Id", "dbo.Pessoa");
            DropIndex("dbo.Reserva", new[] { "Fornecedor_Id" });
            DropIndex("dbo.Reserva", new[] { "Agencia_Id" });
            DropIndex("dbo.Reserva", new[] { "Cliente_Id" });
            DropIndex("dbo.Endereco", new[] { "Pessoa_Id" });
            DropIndex("dbo.Contato", new[] { "Pessoa_Id" });
            DropTable("dbo.Reserva");
            DropTable("dbo.Endereco");
            DropTable("dbo.Contato");
        }
    }
}
