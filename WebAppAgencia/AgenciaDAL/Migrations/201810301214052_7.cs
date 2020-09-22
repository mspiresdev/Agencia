namespace AgenciaDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _7 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pessoa_Id = c.Int(nullable: false),
                        Usu = c.String(nullable: false),
                        Senha = c.String(nullable: false),
                        Registro = c.DateTime(nullable: false),
                        Visivel = c.Boolean(),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.Pessoa_Id)
                .Index(t => t.Pessoa_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuario", "Pessoa_Id", "dbo.Pessoa");
            DropIndex("dbo.Usuario", new[] { "Pessoa_Id" });
            DropTable("dbo.Usuario");
        }
    }
}
