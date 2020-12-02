namespace _361Score.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMatchEventTableWithRelatedTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MatchEvents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Minute = c.Int(nullable: false),
                        Extra = c.Int(nullable: false),
                        TeamId = c.Int(nullable: false),
                        MatchId = c.Int(nullable: false),
                        PlayerId = c.Int(nullable: false),
                        EventType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EventTypes", t => t.EventType)
                .ForeignKey("dbo.Matches", t => t.MatchId)
                .ForeignKey("dbo.Players", t => t.PlayerId)
                .ForeignKey("dbo.Teams", t => t.TeamId)
                .Index(t => t.TeamId)
                .Index(t => t.MatchId)
                .Index(t => t.PlayerId)
                .Index(t => t.EventType);
            
            CreateTable(
                "dbo.EventTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EventName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MatchEvents", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.MatchEvents", "PlayerId", "dbo.Players");
            DropForeignKey("dbo.MatchEvents", "MatchId", "dbo.Matches");
            DropForeignKey("dbo.MatchEvents", "EventType", "dbo.EventTypes");
            DropIndex("dbo.MatchEvents", new[] { "EventType" });
            DropIndex("dbo.MatchEvents", new[] { "PlayerId" });
            DropIndex("dbo.MatchEvents", new[] { "MatchId" });
            DropIndex("dbo.MatchEvents", new[] { "TeamId" });
            DropTable("dbo.EventTypes");
            DropTable("dbo.MatchEvents");
        }
    }
}
