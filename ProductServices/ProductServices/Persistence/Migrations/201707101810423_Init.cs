namespace ProductServices.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 50),
                        ProductCode = c.String(nullable: false, maxLength: 10),
                        ReleaseDate = c.DateTime(nullable: false),
                        Description = c.String(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Category = c.String(nullable: false, maxLength: 50),
                        ImageUrl = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        TagId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        SearchTag = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.TagId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tags", "ProductId", "dbo.Products");
            DropIndex("dbo.Tags", new[] { "ProductId" });
            DropTable("dbo.Tags");
            DropTable("dbo.Products");
        }
    }
}
