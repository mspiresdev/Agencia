namespace AgenciaDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pessoa", "Usuario_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Pessoa", "Usuario_Id1", c => c.Int());
            CreateIndex("dbo.Pessoa", "Usuario_Id1");
            AddForeignKey("dbo.Pessoa", "Usuario_Id1", "dbo.Usuario", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pessoa", "Usuario_Id1", "dbo.Usuario");
            DropIndex("dbo.Pessoa", new[] { "Usuario_Id1" });
            DropColumn("dbo.Pessoa", "Usuario_Id1");
            DropColumn("dbo.Pessoa", "Usuario_Id");
        }
    }
}
