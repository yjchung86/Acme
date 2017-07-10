namespace ProductServices.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTags : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO Tags (ProductId, SearchTag ) Values (1, 'tool')");
            Sql(@"INSERT INTO Tags (ProductId, SearchTag ) Values (1, 'leaf')");

            Sql(@"INSERT INTO Tags (ProductId, SearchTag ) Values (2, 'barrow')");
            Sql(@"INSERT INTO Tags (ProductId, SearchTag ) Values (2, 'cart')");
            Sql(@"INSERT INTO Tags (ProductId, SearchTag ) Values (2, 'wheelbarrow')");

        }

        public override void Down()
        {
            Sql(@"DELETE FROM Tags");
        }
    }
}
