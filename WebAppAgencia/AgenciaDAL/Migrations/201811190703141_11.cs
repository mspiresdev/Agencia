namespace AgenciaDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _11 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Usuario", "Pessoa_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Pessoa", "Usuario_Id1", "dbo.Usuario");
            DropIndex("dbo.Pessoa", new[] { "Usuario_Id1" });
            DropIndex("dbo.Usuario", new[] { "Pessoa_Id" });
            DropColumn("dbo.Pessoa", "Usuario_Id");
            DropColumn("dbo.Pessoa", "Usuario_Id1");
            DropColumn("dbo.Usuario", "Pessoa_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuario", "Pessoa_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Pessoa", "Usuario_Id1", c => c.Int());
            AddColumn("dbo.Pessoa", "Usuario_Id", c => c.Int());
            CreateIndex("dbo.Usuario", "Pessoa_Id");
            CreateIndex("dbo.Pessoa", "Usuario_Id1");
            AddForeignKey("dbo.Pessoa", "Usuario_Id1", "dbo.Usuario", "Id");
            AddForeignKey("dbo.Usuario", "Pessoa_Id", "dbo.Pessoa", "Id");
        }
    }
}
