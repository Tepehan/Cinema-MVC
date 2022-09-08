namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_admin_table_mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        adminId = c.Int(nullable: false, identity: true),
                        adminAdi = c.String(maxLength: 20),
                        adminSoyadi = c.String(maxLength: 20),
                        kullaniciAd = c.String(maxLength: 40),
                        sifre = c.String(maxLength: 16),
                        rol = c.String(),
                    })
                .PrimaryKey(t => t.adminId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Admins");
        }
    }
}
