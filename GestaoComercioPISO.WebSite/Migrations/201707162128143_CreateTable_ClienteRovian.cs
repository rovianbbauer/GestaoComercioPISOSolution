namespace GestaoComercioPISO.WebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTable_ClienteRovian : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClienteRovian",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        NomeCompletoRazaoSocial = c.String(nullable: false, maxLength: 255),
                        ApelidoNomeFantasia = c.String(maxLength: 255),
                        CPFCNPJ = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ClienteRovian");
        }
    }
}
