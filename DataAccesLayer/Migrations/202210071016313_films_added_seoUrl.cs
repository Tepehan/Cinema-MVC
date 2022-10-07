namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class films_added_seoUrl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "seoUrl", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "seoUrl");
        }
    }
}
