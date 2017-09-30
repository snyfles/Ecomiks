namespace ecomiks1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class perfil2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Perfil", "NomePerfil", c => c.String(nullable: false, maxLength: 30, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Perfil", "NomePerfil", c => c.String(unicode: false));
        }
    }
}
