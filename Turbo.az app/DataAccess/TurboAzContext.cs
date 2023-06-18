using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.az_app.Entities.Mapping;

namespace Turbo.az_app.DataAccess
{
    public class TurboAzContext:DbContext
    {
        public TurboAzContext()
        :base("TurboAzDB")
        {

        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<BodyType> BodyTypes { get; set; }
        public DbSet<Status> Statuses { get; set; }

    }
}
