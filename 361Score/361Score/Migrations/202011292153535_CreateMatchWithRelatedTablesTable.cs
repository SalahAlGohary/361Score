namespace _361Score.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMatchWithRelatedTablesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamH = c.Int(nullable: false),
                        TeamA = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        TVChannel = c.String(),
                        Round = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        HResult = c.Int(nullable: false),
                        AResult = c.Int(nullable: false),
                        ComVerId = c.Int(nullable: false),
                        Team_Id = c.Int(),
                        Team_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CompetitionVersions", t => t.ComVerId )
                .ForeignKey("dbo.MatchStatus", t => t.Status)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id1)
                .ForeignKey("dbo.Teams", t => t.TeamA)
                .ForeignKey("dbo.Teams", t => t.TeamH)
                .Index(t => t.TeamH)
                .Index(t => t.TeamA)
                .Index(t => t.Status)
                .Index(t => t.ComVerId)
                .Index(t => t.Team_Id)
                .Index(t => t.Team_Id1);
            
            CreateTable(
                "dbo.MatchStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matches", "TeamH", "dbo.Teams");
            DropForeignKey("dbo.Matches", "TeamA", "dbo.Teams");
            DropForeignKey("dbo.Matches", "Team_Id1", "dbo.Teams");
            DropForeignKey("dbo.Matches", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.Matches", "Status", "dbo.MatchStatus");
            DropForeignKey("dbo.Matches", "ComVerId", "dbo.CompetitionVersions");
            DropIndex("dbo.Matches", new[] { "Team_Id1" });
            DropIndex("dbo.Matches", new[] { "Team_Id" });
            DropIndex("dbo.Matches", new[] { "ComVerId" });
            DropIndex("dbo.Matches", new[] { "Status" });
            DropIndex("dbo.Matches", new[] { "TeamA" });
            DropIndex("dbo.Matches", new[] { "TeamH" });
            DropTable("dbo.MatchStatus");
            DropTable("dbo.Matches");
        }
    }
}
