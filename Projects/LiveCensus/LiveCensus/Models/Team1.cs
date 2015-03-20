namespace LiveCensus.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Team1 : DbContext
    {
        public Team1()
            : base("name=Team1")
        {
        }

        public virtual DbSet<LCEN_HOURS> LCEN_HOURS { get; set; }
        public virtual DbSet<LCEN_SHIFTS> LCEN_SHIFTS { get; set; }
        public virtual DbSet<LCEN_TEAM1> LCEN_TEAM1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LCEN_HOURS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LCEN_HOURS>()
                .Property(e => e.HRNUM)
                .IsUnicode(false);

            modelBuilder.Entity<LCEN_HOURS>()
                .Property(e => e.HRDISP)
                .IsUnicode(false);

            modelBuilder.Entity<LCEN_HOURS>()
                .Property(e => e.SHIFT)
                .IsUnicode(false);

            modelBuilder.Entity<LCEN_SHIFTS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LCEN_SHIFTS>()
                .Property(e => e.SHIFTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<LCEN_SHIFTS>()
                .Property(e => e.SHIFTDISP)
                .IsUnicode(false);

            modelBuilder.Entity<LCEN_TEAM1>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LCEN_TEAM1>()
                .Property(e => e.HOUR)
                .IsUnicode(false);

            modelBuilder.Entity<LCEN_TEAM1>()
                .Property(e => e.SHIFT)
                .IsUnicode(false);

            modelBuilder.Entity<LCEN_TEAM1>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<LCEN_TEAM1>()
                .Property(e => e.EDITEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<LCEN_TEAM1>()
                .Property(e => e.CELL1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LCEN_TEAM1>()
                .Property(e => e.CELL2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LCEN_TEAM1>()
                .Property(e => e.CELL3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LCEN_TEAM1>()
                .Property(e => e.CELL4)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LCEN_TEAM1>()
                .Property(e => e.CELL6)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LCEN_TEAM1>()
                .Property(e => e.CELL7)
                .HasPrecision(38, 0);
        }
    }
}
