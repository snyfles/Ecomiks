namespace ecomiks1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pessoa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        PessoaID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        RG = c.String(unicode: false),
                        DataNascimento = c.String(unicode: false),
                        CPF = c.String(unicode: false),
                        Email = c.String(unicode: false),
                        Sexo = c.String(unicode: false),
                        Rua = c.String(unicode: false),
                        NumeroEndereco = c.String(unicode: false),
                        Bairro = c.String(unicode: false),
                        Cidade = c.String(unicode: false),
                        DataHoraCadastro = c.DateTime(nullable: false, precision: 0),
                        SenhaAcesso = c.String(unicode: false),
                        PerfilID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PessoaID)
                .ForeignKey("dbo.Perfil", t => t.PerfilID, cascadeDelete: true)
                .Index(t => t.PerfilID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pessoa", "PerfilID", "dbo.Perfil");
            DropIndex("dbo.Pessoa", new[] { "PerfilID" });
            DropTable("dbo.Pessoa");
        }
    }
}
