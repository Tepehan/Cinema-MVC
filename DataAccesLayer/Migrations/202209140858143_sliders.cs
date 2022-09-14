namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sliders : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sliders",
                c => new
                    {
                        sliderId = c.Int(nullable: false, identity: true),
                        baslik = c.String(maxLength: 20),
                        icerik = c.String(maxLength: 100),
                        resimUrl = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.sliderId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sliders");
        }
    }
}
