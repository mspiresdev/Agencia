namespace AgenciaDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MaterialServico", "PessoaMaterial_Id1", "dbo.Pessoa");
            DropIndex("dbo.MaterialServico", new[] { "PessoaMaterial_Id1" });
            CreateTable(
                "dbo.TipoPessoa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Registro = c.DateTime(nullable: false),
                        Visivel = c.Boolean(),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Veiculo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pessoa_Id = c.Int(nullable: false),
                        Placa = c.String(nullable: false),
                        Modelo = c.String(),
                        Assentos = c.Int(nullable: false),
                        Obs = c.Int(nullable: false),
                        Registro = c.DateTime(nullable: false),
                        Visivel = c.Boolean(),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.Pessoa_Id)
                .Index(t => t.Pessoa_Id);
            
            AddColumn("dbo.Pessoa", "RazaoSocial", c => c.String());
            AddColumn("dbo.Pessoa", "CNH", c => c.String());
            AddColumn("dbo.Pessoa", "NrCadastur", c => c.String());
            AddColumn("dbo.Pessoa", "Responsavel", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pessoa", "TipoPessoa_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Pessoa", "Pessoa_Id", c => c.Int());
            AddColumn("dbo.Pessoa", "Tipo_Id", c => c.Int());
            CreateIndex("dbo.Pessoa", "Pessoa_Id");
            CreateIndex("dbo.Pessoa", "Tipo_Id");
            AddForeignKey("dbo.Pessoa", "Pessoa_Id", "dbo.Pessoa", "Id");
            AddForeignKey("dbo.Pessoa", "Tipo_Id", "dbo.TipoPessoa", "Id");
            DropColumn("dbo.MaterialServico", "PessoaMaterial_Id");
            DropColumn("dbo.MaterialServico", "PessoaMaterial_Id1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MaterialServico", "PessoaMaterial_Id1", c => c.Int());
            AddColumn("dbo.MaterialServico", "PessoaMaterial_Id", c => c.Int());
            DropForeignKey("dbo.Veiculo", "Pessoa_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Pessoa", "Tipo_Id", "dbo.TipoPessoa");
            DropForeignKey("dbo.Pessoa", "Pessoa_Id", "dbo.Pessoa");
            DropIndex("dbo.Veiculo", new[] { "Pessoa_Id" });
            DropIndex("dbo.Pessoa", new[] { "Tipo_Id" });
            DropIndex("dbo.Pessoa", new[] { "Pessoa_Id" });
            DropColumn("dbo.Pessoa", "Tipo_Id");
            DropColumn("dbo.Pessoa", "Pessoa_Id");
            DropColumn("dbo.Pessoa", "TipoPessoa_Id");
            DropColumn("dbo.Pessoa", "Responsavel");
            DropColumn("dbo.Pessoa", "NrCadastur");
            DropColumn("dbo.Pessoa", "CNH");
            DropColumn("dbo.Pessoa", "RazaoSocial");
            DropTable("dbo.Veiculo");
            DropTable("dbo.TipoPessoa");
            CreateIndex("dbo.MaterialServico", "PessoaMaterial_Id1");
            AddForeignKey("dbo.MaterialServico", "PessoaMaterial_Id1", "dbo.Pessoa", "Id");
        }
    }
}
