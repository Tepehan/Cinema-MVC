namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gosterimSaat_gosterimGun : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SalonFilms", "gosterimTarih", c => c.String(maxLength: 20));
            AddColumn("dbo.SalonFilms", "gosterimGun", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SalonFilms", "gosterimGun");
            DropColumn("dbo.SalonFilms", "gosterimTarih");
        }
    }
}
