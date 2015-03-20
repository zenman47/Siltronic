using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LiveCensus.Models
{
    public class LiveCensusContext : DbContext
    {
        public DbSet<Team1> Team1 { get; set; }

        public DbSet<Team2> Team2 { get; set; }

        public DbSet<hour> hours { get; set; }

        public DbSet<shift> shifts { get; set; }

    }
}