using System.Data.Entity.Migrations;

namespace ProductServices.Persistence.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<App1DbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Persistence\Migrations";
        }
    }
}
