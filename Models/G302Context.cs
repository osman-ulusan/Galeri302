using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Galeri302.Models
{
    public class G302Context:DbContext
    {
        public G302Context():base("bag")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<G302Context, Migrations.Configuration>("bag"));
        }
        public virtual DbSet<Araclar> Araclars { get; set; }
        public virtual DbSet<yCity> Sehirler { get; set; }

        public System.Data.Entity.DbSet<Galeri302.Models.yVites> yVites { get; set; }

        public System.Data.Entity.DbSet<Galeri302.Models.yYakitTipi> yYakitTipis { get; set; }
    }
}