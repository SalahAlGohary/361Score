namespace _361Score.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePlayerPositionTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlayerPositions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Position = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Players", "Position");
            AddForeignKey("dbo.Players", "Position", "dbo.PlayerPositions", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "Position", "dbo.PlayerPositions");
            DropIndex("dbo.Players", new[] { "Position" });
            DropTable("dbo.PlayerPositions");
        }
    }
}
