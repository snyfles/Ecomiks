namespace ecomiks1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class perfil : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Perfil",
                c => new
                    {
                        PerfilID = c.Int(nullable: false, identity: true),
                        NomePerfil = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.PerfilID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Perfil");
        }
    }
}
