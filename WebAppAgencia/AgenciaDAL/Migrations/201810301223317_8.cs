namespace AgenciaDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _8 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Perfil",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        FullAcesso = c.Boolean(),
                        Hieranquia = c.Int(),
                        Usuario_Id = c.Int(nullable: false),
                        Registro = c.DateTime(nullable: false),
                        Visivel = c.Boolean(),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuario", t => t.Usuario_Id)
                .Index(t => t.Usuario_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Perfil", "Usuario_Id", "dbo.Usuario");
            DropIndex("dbo.Perfil", new[] { "Usuario_Id" });
            DropTable("dbo.Perfil");
        }
    }
}
