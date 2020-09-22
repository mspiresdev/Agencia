namespace AgenciaDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pessoa", "Pessoa_Id", "dbo.Pessoa");
            DropIndex("dbo.Pessoa", new[] { "Pessoa_Id" });
            DropIndex("dbo.Pessoa", new[] { "Tipo_Id" });
            DropColumn("dbo.Pessoa", "TipoPessoa_Id");
            RenameColumn(table: "dbo.Pessoa", name: "Tipo_Id", newName: "TipoPessoa_Id");
            AlterColumn("dbo.Pessoa", "TipoPessoa_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Pessoa", "TipoPessoa_Id");
            DropColumn("dbo.Pessoa", "Pessoa_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pessoa", "Pessoa_Id", c => c.Int());
            DropIndex("dbo.Pessoa", new[] { "TipoPessoa_Id" });
            AlterColumn("dbo.Pessoa", "TipoPessoa_Id", c => c.Int());
            RenameColumn(table: "dbo.Pessoa", name: "TipoPessoa_Id", newName: "Tipo_Id");
            AddColumn("dbo.Pessoa", "TipoPessoa_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Pessoa", "Tipo_Id");
            CreateIndex("dbo.Pessoa", "Pessoa_Id");
            AddForeignKey("dbo.Pessoa", "Pessoa_Id", "dbo.Pessoa", "Id");
        }
    }
}
