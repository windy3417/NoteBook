namespace NoteBook.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NoteBook.DAL.NoteBookContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
           
        }

        protected override void Seed(NoteBook.DAL.NoteBookContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
