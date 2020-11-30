namespace _361Score.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTeamWithRelatedTablesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CountryName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Logo = c.String(),
                        CoachName = c.String(),
                        CoachImg = c.String(),
                        ClubTeam = c.Boolean(nullable: false),
                        Country = c.Int(nullable: false),
                        Continent = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Continents", t => t.Continent, cascadeDelete: true)
                .ForeignKey("dbo.Countries", t => t.Country, cascadeDelete: true)
                .Index(t => t.Country)
                .Index(t => t.Continent);
            
            CreateTable(
                "dbo.Continents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContinentName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Players", "CountryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Players", "CountryId");
            AddForeignKey("dbo.Players", "CountryId", "dbo.Countries", "Id", cascadeDelete: true);
            DropColumn("dbo.Players", "Country");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "Country", c => c.Int(nullable: false));
            DropForeignKey("dbo.Players", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Teams", "Country", "dbo.Countries");
            DropForeignKey("dbo.Teams", "Continent", "dbo.Continents");
            DropIndex("dbo.Teams", new[] { "Continent" });
            DropIndex("dbo.Teams", new[] { "Country" });
            DropIndex("dbo.Players", new[] { "CountryId" });
            DropColumn("dbo.Players", "CountryId");
            DropTable("dbo.Continents");
            DropTable("dbo.Teams");
            DropTable("dbo.Countries");
        }
    }
}
