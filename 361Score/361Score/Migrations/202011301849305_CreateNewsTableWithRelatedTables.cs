namespace _361Score.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateNewsTableWithRelatedTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Image = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NewsTags",
                c => new
                    {
                        NewsId = c.Int(nullable: false),
                        TagId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.NewsId, t.TagId })
                .ForeignKey("dbo.News", t => t.NewsId)
                .ForeignKey("dbo.Tags", t => t.TagId)
                .Index(t => t.NewsId)
                .Index(t => t.TagId);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NewsTags", "TagId", "dbo.Tags");
            DropForeignKey("dbo.NewsTags", "NewsId", "dbo.News");
            DropIndex("dbo.NewsTags", new[] { "TagId" });
            DropIndex("dbo.NewsTags", new[] { "NewsId" });
            DropTable("dbo.Tags");
            DropTable("dbo.NewsTags");
            DropTable("dbo.News");
        }
    }
}
