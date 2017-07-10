namespace ProductServices.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateProducts : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO Products (ProductName, ProductCode, ReleaseDate, Description, Cost, Price, Category, ImageUrl)
                Values ('Leaf Rake', 'GDN-0011', 'March 19, 2009', 'Leaf rake with 48-inch wooden handle.', 9.00, 19.95, 'garden', 'http://openclipart.org/image/300px/svg_to_png/26215/Anonymous_Leaf_Rake.png')
                ");

            Sql(@"INSERT INTO Products (ProductName, ProductCode, ReleaseDate, Description, Cost, Price, Category, ImageUrl)
                Values ('Garden Cart', 'GDN-0023', 'March 18, 2010', '15 gallon capacity rolling garden cart', 20.00, 32.99, 'garden', 'http://openclipart.org/image/300px/svg_to_png/58471/garden_cart.png')
                ");

            Sql(@"INSERT INTO Products (ProductName, ProductCode, ReleaseDate, Description, Cost, Price, Category, ImageUrl)
                Values ('Hammer', 'TBX-0048', 'May 21, 2013', 'Curved claw steel hammer', 1.00, 8.99, 'toolbox', 'http://openclipart.org/image/300px/svg_to_png/73/rejon_Hammer.png')
                ");

            Sql(@"INSERT INTO Products (ProductName, ProductCode, ReleaseDate, Description, Cost, Price, Category, ImageUrl)
                Values ('Saw', 'TBX-0022', 'May 15, 2009', '15-inch steel blade hand saw', 6.95, 11.55, 'garden', 'http://openclipart.org/image/300px/svg_to_png/27070/egore911_saw.png')
                ");

            Sql(@"INSERT INTO Products (ProductName, ProductCode, ReleaseDate, Description, Cost, Price, Category, ImageUrl)
                Values ('Video Game Controller', 'GMG-0042', 'October 15, 2002', 'Standard two-button video game controller', 2.22, 35.95, 'gaming', 'http://openclipart.org/image/300px/svg_to_png/120337/xbox-controller_01.png')
                ");

            Sql(@"INSERT INTO Products (ProductName, ProductCode, ReleaseDate, Description, Cost, Price, Category, ImageUrl)
                Values ('Leaf Rake New', 'GDN-0012', 'March 19, 2009', 'Leaf rake with 48-inch wooden handle.', 9.00, 19.95, 'garden', 'http://openclipart.org/image/300px/svg_to_png/26215/Anonymous_Leaf_Rake.png')
                ");

            Sql(@"INSERT INTO Products (ProductName, ProductCode, ReleaseDate, Description, Cost, Price, Category, ImageUrl)
                Values ('Garden Cart New', 'GDN-0024', 'March 18, 2010', '15 gallon capacity rolling garden cart', 20.00, 32.99, 'garden', 'http://openclipart.org/image/300px/svg_to_png/58471/garden_cart.png')
                ");

            Sql(@"INSERT INTO Products (ProductName, ProductCode, ReleaseDate, Description, Cost, Price, Category, ImageUrl)
                Values ('Hammer New', 'TBX-0049', 'May 21, 2013', 'Curved claw steel hammer', 1.00, 8.99, 'toolbox', 'http://openclipart.org/image/300px/svg_to_png/73/rejon_Hammer.png')
                ");

            Sql(@"INSERT INTO Products (ProductName, ProductCode, ReleaseDate, Description, Cost, Price, Category, ImageUrl)
                Values ('Saw New', 'TBX-0023', 'May 15, 2009', '15-inch steel blade hand saw', 6.95, 11.55, 'garden', 'http://openclipart.org/image/300px/svg_to_png/27070/egore911_saw.png')
                ");

            Sql(@"INSERT INTO Products (ProductName, ProductCode, ReleaseDate, Description, Cost, Price, Category, ImageUrl)
                Values ('Video Game Controller New', 'GMG-0043', 'October 15, 2002', 'Standard two-button video game controller', 2.22, 35.95, 'gaming', 'http://openclipart.org/image/300px/svg_to_png/120337/xbox-controller_01.png')
                ");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Products WHERE ProductId <= 10");
        }
    }
}
