namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tarih : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musteris", "gun", c => c.String(maxLength: 2));
            AddColumn("dbo.Musteris", "ay", c => c.String(maxLength: 2));
            AddColumn("dbo.Musteris", "yil", c => c.String(maxLength: 4));
            DropColumn("dbo.Musteris", "dogumTarih");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Musteris", "dogumTarih", c => c.String(maxLength: 20));
            DropColumn("dbo.Musteris", "yil");
            DropColumn("dbo.Musteris", "ay");
            DropColumn("dbo.Musteris", "gun");
        }
    }
}
