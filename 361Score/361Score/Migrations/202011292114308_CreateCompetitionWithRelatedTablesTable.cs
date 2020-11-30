namespace _361Score.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCompetitionWithRelatedTablesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CompetitionCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Competitions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompetionName = c.String(nullable: false),
                        Category = c.Int(nullable: false),
                        Logo = c.String(),
                        Country = c.Int(nullable: false),
                        Contenent = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CompetitionCategories", t => t.Category, cascadeDelete: true)
                .ForeignKey("dbo.CompetitionTypes", t => t.Type, cascadeDelete: true)
                .ForeignKey("dbo.Continents", t => t.Contenent, cascadeDelete: true)
                .ForeignKey("dbo.Countries", t => t.Country, cascadeDelete: true)
                .Index(t => t.Category)
                .Index(t => t.Country)
                .Index(t => t.Contenent)
                .Index(t => t.Type);
            
            CreateTable(
                "dbo.CompetitionTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CompetitionVersions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Version = c.String(nullable: false),
                        CompetitionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Competitions", t => t.CompetitionId, cascadeDelete: true)
                .Index(t => t.CompetitionId);
            
            CreateTable(
                "dbo.TeamCompetitions",
                c => new
                    {
                        TeamId = c.Int(nullable: false),
                        CompetitionVersionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TeamId, t.CompetitionVersionId })
                .ForeignKey("dbo.CompetitionVersions", t => t.CompetitionVersionId)
                .ForeignKey("dbo.Teams", t => t.TeamId)
                .Index(t => t.TeamId)
                .Index(t => t.CompetitionVersionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Competitions", "Country", "dbo.Countries");
            DropForeignKey("dbo.Competitions", "Contenent", "dbo.Continents");
            DropForeignKey("dbo.TeamCompetitions", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.TeamCompetitions", "CompetitionVersionId", "dbo.CompetitionVersions");
            DropForeignKey("dbo.CompetitionVersions", "CompetitionId", "dbo.Competitions");
            DropForeignKey("dbo.Competitions", "Type", "dbo.CompetitionTypes");
            DropForeignKey("dbo.Competitions", "Category", "dbo.CompetitionCategories");
            DropIndex("dbo.TeamCompetitions", new[] { "CompetitionVersionId" });
            DropIndex("dbo.TeamCompetitions", new[] { "TeamId" });
            DropIndex("dbo.CompetitionVersions", new[] { "CompetitionId" });
            DropIndex("dbo.Competitions", new[] { "Type" });
            DropIndex("dbo.Competitions", new[] { "Contenent" });
            DropIndex("dbo.Competitions", new[] { "Country" });
            DropIndex("dbo.Competitions", new[] { "Category" });
            DropTable("dbo.TeamCompetitions");
            DropTable("dbo.CompetitionVersions");
            DropTable("dbo.CompetitionTypes");
            DropTable("dbo.Competitions");
            DropTable("dbo.CompetitionCategories");
        }
    }
}
