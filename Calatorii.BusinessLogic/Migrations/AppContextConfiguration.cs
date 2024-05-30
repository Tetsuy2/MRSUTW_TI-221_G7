using System.Data.Entity.Migrations;

namespace Calatorii.BusinessLogic.Migrations
{
    internal sealed class AppContextConfiguration : DbMigrationsConfiguration<Calatorii.BusinessLogic.DBModel.AppContext>
    {
        public AppContextConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(Calatorii.BusinessLogic.DBModel.AppContext context)
        {
            // Seed initial data here if necessary
        }
    }
}
