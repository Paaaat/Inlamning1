namespace Inlamning1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inlamning1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Personers", "Födelsedag", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Personers", "Födelsedag", c => c.String());
        }
    }
}
