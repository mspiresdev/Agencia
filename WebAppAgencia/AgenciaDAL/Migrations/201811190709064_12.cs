namespace AgenciaDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pessoa", "Usuario_Id", c => c.Int());
            AddColumn("dbo.Usuario", "Pessoa_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Pessoa", "Usuario_Id");
            CreateIndex("dbo.Usuario", "Pessoa_Id");
            AddForeignKey("dbo.Usuario", "Pessoa_Id", "dbo.Pessoa", "Id");
            AddForeignKey("dbo.Pessoa", "Usuario_Id", "dbo.Usuario", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pessoa", "Usuario_Id", "dbo.Usuario");
            DropForeignKey("dbo.Usuario", "Pessoa_Id", "dbo.Pessoa");
            DropIndex("dbo.Usuario", new[] { "Pessoa_Id" });
            DropIndex("dbo.Pessoa", new[] { "Usuario_Id" });
            DropColumn("dbo.Usuario", "Pessoa_Id");
            DropColumn("dbo.Pessoa", "Usuario_Id");
        }
    }
}
