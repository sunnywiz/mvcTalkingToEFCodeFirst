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

    }

    public class PlanetContext : DbContext
    {
        public DbSet<Planet> Planets { get; set; }
    }
}