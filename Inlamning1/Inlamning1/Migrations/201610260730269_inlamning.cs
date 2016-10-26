namespace Inlamning1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inlamning : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personers",
                c => new
                    {
                        PersonerId = c.Int(nullable: false, identity: true),
                        Namn = c.String(),
                        Gatuadress = c.String(),
                        Postnummer = c.String(),
                        Postort = c.String(),
                        Telefon = c.String(),
                        Epost = c.String(),
                        Födelsedag = c.String(),
                    })
                .PrimaryKey(t => t.PersonerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Personers");
        }
    }
}
