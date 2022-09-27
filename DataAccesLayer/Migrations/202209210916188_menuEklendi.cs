namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class menuEklendi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        menuId = c.Int(nullable: false, identity: true),
                        menuName = c.String(),
                        parentId = c.Int(nullable: false),
                        parent_menuId = c.Int(),
                    })
                .PrimaryKey(t => t.menuId)
                .ForeignKey("dbo.Menus", t => t.parent_menuId)
                .Index(t => t.parent_menuId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Menus", "parent_menuId", "dbo.Menus");
            DropIndex("dbo.Menus", new[] { "parent_menuId" });
            DropTable("dbo.Menus");
        }
    }
}
