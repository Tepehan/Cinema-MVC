namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sifre : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musteris", "sifre", c => c.String(maxLength: 20));
            AlterColumn("dbo.Musteris", "dogumTarih", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Musteris", "dogumTarih", c => c.DateTime(nullable: false));
            DropColumn("dbo.Musteris", "sifre");
        }
    }
}
