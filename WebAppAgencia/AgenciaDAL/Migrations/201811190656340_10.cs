namespace AgenciaDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _10 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pessoa", "Usuario_Id", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pessoa", "Usuario_Id", c => c.Int(nullable: false));
        }
    }
}
