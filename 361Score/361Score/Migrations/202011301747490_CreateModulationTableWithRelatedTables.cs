namespace _361Score.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateModulationTableWithRelatedTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Modulations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ListH = c.Int(nullable: false),
                        ListA = c.Int(nullable: false),
                        MatchId = c.Int(nullable: false),
                        FormationH = c.String(nullable: false),
                        FormationA = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Matches", t => t.MatchId)
                .ForeignKey("dbo.MatchLists", t => t.ListH)
                .ForeignKey("dbo.MatchLists", t => t.ListA)
                .Index(t => t.ListH)
                .Index(t => t.ListA)
                .Index(t => t.MatchId);
            
            CreateTable(
                "dbo.MatchLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlayerId = c.Int(nullable: false),
                        ParticipationType = c.Boolean(nullable: false),
                        FormationPosition = c.Int(nullable: false),
                        modulation1_Id = c.Int(),
                        modulation2_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Modulations", t => t.modulation1_Id)
                .ForeignKey("dbo.Modulations", t => t.modulation2_Id)
                .ForeignKey("dbo.Players", t => t.PlayerId)
                .Index(t => t.PlayerId)
                .Index(t => t.modulation1_Id)
                .Index(t => t.modulation2_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Modulations", "ListA", "dbo.MatchLists");
            DropForeignKey("dbo.Modulations", "ListH", "dbo.MatchLists");
            DropForeignKey("dbo.MatchLists", "PlayerId", "dbo.Players");
            DropForeignKey("dbo.MatchLists", "modulation2_Id", "dbo.Modulations");
            DropForeignKey("dbo.MatchLists", "modulation1_Id", "dbo.Modulations");
            DropForeignKey("dbo.Modulations", "MatchId", "dbo.Matches");
            DropIndex("dbo.MatchLists", new[] { "modulation2_Id" });
            DropIndex("dbo.MatchLists", new[] { "modulation1_Id" });
            DropIndex("dbo.MatchLists", new[] { "PlayerId" });
            DropIndex("dbo.Modulations", new[] { "MatchId" });
            DropIndex("dbo.Modulations", new[] { "ListA" });
            DropIndex("dbo.Modulations", new[] { "ListH" });
            DropTable("dbo.MatchLists");
            DropTable("dbo.Modulations");
        }
    }
}
