using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcEFCodeFirstCRUD.Models
{
    public class Planet
    {
        public int PlanetID { get; set; }
        public string Name { get; set; }
        public long Population { get; set; }
    }

    public class PlanetContext : DbContext
    {
        public DbSet<Planet> Planets { get; set; }

        public PlanetContext()
        {
            Database.SetInitializer<PlanetContext>(new MyInitializer());
        }

        public class MyInitializer : DropCreateDatabaseIfModelChanges<PlanetContext>
        {
            public override void InitializeDatabase(PlanetContext context)
            {
                base.InitializeDatabase(context);
                if (!context.Planets.Any(x => x.Name == "Earth"))
                {
                    context.Planets.Add(new Models.Planet()
                    {
                        Name = "Earth",
                        Population = 7000000000L
                    });
                    context.SaveChanges();
                }
            }

        }
    }
}