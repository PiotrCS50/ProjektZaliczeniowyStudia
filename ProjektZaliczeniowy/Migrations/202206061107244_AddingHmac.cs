namespace ProjektZaliczeniowy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingHmac : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Uzytkownicy", "HasloHash", c => c.Binary(nullable: false));
            AddColumn("dbo.Uzytkownicy", "HasloSalt", c => c.Binary(nullable: false));
            DropColumn("dbo.Uzytkownicy", "Haslo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Uzytkownicy", "Haslo", c => c.String(nullable: false));
            DropColumn("dbo.Uzytkownicy", "HasloSalt");
            DropColumn("dbo.Uzytkownicy", "HasloHash");
        }
    }
}
