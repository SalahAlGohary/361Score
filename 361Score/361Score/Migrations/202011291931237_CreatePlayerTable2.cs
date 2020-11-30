namespace _361Score.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePlayerTable2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FName = c.String(nullable: false),
                        LName = c.String(),
                        ClubId = c.Int(nullable: false),
                        ClubNum = c.Int(nullable: false),
                        TeamId = c.Int(nullable: false),
                        TeamNum = c.Int(nullable: false),
                        ImagePath = c.String(),
                        Position = c.Int(nullable: false),
                        Country = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Players");
        }
    }
}
