namespace AgenciaDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Itinerario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Descricao = c.String(),
                        Registro = c.DateTime(nullable: false),
                        Visivel = c.Boolean(),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Contato", "Visivel", c => c.Boolean());
            AddColumn("dbo.Pessoa", "Visivel", c => c.Boolean());
            AddColumn("dbo.Endereco", "Visivel", c => c.Boolean());
            AddColumn("dbo.Reserva", "Origem_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Reserva", "Destino_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Reserva", "Visivel", c => c.Boolean());
            AddColumn("dbo.Servico", "Visivel", c => c.Boolean());
            AddColumn("dbo.MaterialServico", "Visivel", c => c.Boolean());
            CreateIndex("dbo.Reserva", "Origem_Id");
            CreateIndex("dbo.Reserva", "Destino_Id");
            AddForeignKey("dbo.Reserva", "Destino_Id", "dbo.Itinerario", "Id");
            AddForeignKey("dbo.Reserva", "Origem_Id", "dbo.Itinerario", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reserva", "Origem_Id", "dbo.Itinerario");
            DropForeignKey("dbo.Reserva", "Destino_Id", "dbo.Itinerario");
            DropIndex("dbo.Reserva", new[] { "Destino_Id" });
            DropIndex("dbo.Reserva", new[] { "Origem_Id" });
            DropColumn("dbo.MaterialServico", "Visivel");
            DropColumn("dbo.Servico", "Visivel");
            DropColumn("dbo.Reserva", "Visivel");
            DropColumn("dbo.Reserva", "Destino_Id");
            DropColumn("dbo.Reserva", "Origem_Id");
            DropColumn("dbo.Endereco", "Visivel");
            DropColumn("dbo.Pessoa", "Visivel");
            DropColumn("dbo.Contato", "Visivel");
            DropTable("dbo.Itinerario");
        }
    }
}
