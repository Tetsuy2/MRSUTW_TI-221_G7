using System.Data.Entity.Migrations;

namespace Calatorii.BusinessLogic.DBModel.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AppContext context)
        {
            // Seed data
        }
    }
}
