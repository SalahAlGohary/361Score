namespace _361Score.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateStatisticsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Statistics",
                c => new
                    {
                        PlayerId = c.Int(nullable: false),
                        TeamId = c.Int(nullable: false),
                        ComVerId = c.Int(nullable: false),
                        Goals = c.Int(nullable: false),
                        Assists = c.Int(nullable: false),
                        RedCards = c.Int(nullable: false),
                        YellowCards = c.Int(nullable: false),
                        Penalities = c.Int(nullable: false),
                        PlayTimes = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PlayerId, t.TeamId, t.ComVerId })
                .ForeignKey("dbo.CompetitionVersions", t => t.ComVerId)
                .ForeignKey("dbo.Players", t => t.PlayerId)
                .ForeignKey("dbo.Teams", t => t.TeamId)
                .Index(t => t.PlayerId)
                .Index(t => t.TeamId)
                .Index(t => t.ComVerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Statistics", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.Statistics", "PlayerId", "dbo.Players");
            DropForeignKey("dbo.Statistics", "ComVerId", "dbo.CompetitionVersions");
            DropIndex("dbo.Statistics", new[] { "ComVerId" });
            DropIndex("dbo.Statistics", new[] { "TeamId" });
            DropIndex("dbo.Statistics", new[] { "PlayerId" });
            DropTable("dbo.Statistics");
        }
    }
}
