namespace ProjektZaliczeniowy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Final_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategorie",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Koszyks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PozycjeKoszyka",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ilosc = c.Int(nullable: false),
                        Cena = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Suma = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Produkt_Id = c.Int(),
                        Koszyk_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produkty", t => t.Produkt_Id)
                .ForeignKey("dbo.Koszyks", t => t.Koszyk_Id)
                .Index(t => t.Produkt_Id)
                .Index(t => t.Koszyk_Id);
            
            CreateTable(
                "dbo.Produkty",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(nullable: false),
                        Opis = c.String(nullable: false),
                        Kategoria_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategorie", t => t.Kategoria_Id, cascadeDelete: true)
                .Index(t => t.Kategoria_Id);
            
            CreateTable(
                "dbo.Magazyny",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                        Domyslny = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PozycjeMagazynu",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ilosc = c.Int(nullable: false),
                        Cena = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Magazyn_Id = c.Int(),
                        Produkt_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Magazyny", t => t.Magazyn_Id)
                .ForeignKey("dbo.Produkty", t => t.Produkt_Id)
                .Index(t => t.Magazyn_Id)
                .Index(t => t.Produkt_Id);
            
            CreateTable(
                "dbo.Uzytkownicy",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(nullable: false),
                        Imie = c.String(nullable: false),
                        Nazwisko = c.String(nullable: false),
                        Haslo = c.String(nullable: false),
                        TypKonta = c.String(nullable: false),
                        Pieniadze = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Koszyk_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Koszyks", t => t.Koszyk_Id)
                .Index(t => t.Koszyk_Id);
            
            CreateTable(
                "dbo.Zamowienia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Uzytkownik_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Uzytkownicy", t => t.Uzytkownik_Id)
                .Index(t => t.Uzytkownik_Id);
            
            CreateTable(
                "dbo.PozycjeZamowienia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ilosc = c.Int(nullable: false),
                        Cena = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Suma = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Produkt_Id = c.Int(),
                        Zamowienie_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produkty", t => t.Produkt_Id)
                .ForeignKey("dbo.Zamowienia", t => t.Zamowienie_Id)
                .Index(t => t.Produkt_Id)
                .Index(t => t.Zamowienie_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Zamowienia", "Uzytkownik_Id", "dbo.Uzytkownicy");
            DropForeignKey("dbo.PozycjeZamowienia", "Zamowienie_Id", "dbo.Zamowienia");
            DropForeignKey("dbo.PozycjeZamowienia", "Produkt_Id", "dbo.Produkty");
            DropForeignKey("dbo.Uzytkownicy", "Koszyk_Id", "dbo.Koszyks");
            DropForeignKey("dbo.PozycjeMagazynu", "Produkt_Id", "dbo.Produkty");
            DropForeignKey("dbo.PozycjeMagazynu", "Magazyn_Id", "dbo.Magazyny");
            DropForeignKey("dbo.PozycjeKoszyka", "Koszyk_Id", "dbo.Koszyks");
            DropForeignKey("dbo.PozycjeKoszyka", "Produkt_Id", "dbo.Produkty");
            DropForeignKey("dbo.Produkty", "Kategoria_Id", "dbo.Kategorie");
            DropIndex("dbo.PozycjeZamowienia", new[] { "Zamowienie_Id" });
            DropIndex("dbo.PozycjeZamowienia", new[] { "Produkt_Id" });
            DropIndex("dbo.Zamowienia", new[] { "Uzytkownik_Id" });
            DropIndex("dbo.Uzytkownicy", new[] { "Koszyk_Id" });
            DropIndex("dbo.PozycjeMagazynu", new[] { "Produkt_Id" });
            DropIndex("dbo.PozycjeMagazynu", new[] { "Magazyn_Id" });
            DropIndex("dbo.Produkty", new[] { "Kategoria_Id" });
            DropIndex("dbo.PozycjeKoszyka", new[] { "Koszyk_Id" });
            DropIndex("dbo.PozycjeKoszyka", new[] { "Produkt_Id" });
            DropTable("dbo.PozycjeZamowienia");
            DropTable("dbo.Zamowienia");
            DropTable("dbo.Uzytkownicy");
            DropTable("dbo.PozycjeMagazynu");
            DropTable("dbo.Magazyny");
            DropTable("dbo.Produkty");
            DropTable("dbo.PozycjeKoszyka");
            DropTable("dbo.Koszyks");
            DropTable("dbo.Kategorie");
        }
    }
}
