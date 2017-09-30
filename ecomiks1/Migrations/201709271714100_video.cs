namespace ecomiks1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class video : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Video",
                c => new
                    {
                        videoID = c.Int(nullable: false, identity: true),
                        videoNome = c.String(unicode: false),
                        videoUrl = c.String(unicode: false),
                        videoDescricao = c.String(unicode: false),
                        videoCategoria = c.String(unicode: false),
                        videoAvaliacao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.videoID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Video");
        }
    }
}
