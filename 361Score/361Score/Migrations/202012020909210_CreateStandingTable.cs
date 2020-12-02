namespace _361Score.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateStandingTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Standings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamId = c.Int(nullable: false),
                        ComVerId = c.Int(nullable: false),
                        Group = c.Int(nullable: false),
                        Play = c.Int(nullable: false),
                        Win = c.Int(nullable: false),
                        Draw = c.Int(nullable: false),
                        Lose = c.Int(nullable: false),
                        GoalsFor = c.Int(nullable: false),
                        GoalsTo = c.Int(nullable: false),
                        GoalsDiff = c.Int(nullable: false),
                        Points = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CompetitionVersions", t => t.ComVerId)
                .ForeignKey("dbo.Teams", t => t.TeamId)
                .Index(t => t.TeamId)
                .Index(t => t.ComVerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Standings", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.Standings", "ComVerId", "dbo.CompetitionVersions");
            DropIndex("dbo.Standings", new[] { "ComVerId" });
            DropIndex("dbo.Standings", new[] { "TeamId" });
            DropTable("dbo.Standings");
        }
    }
}
