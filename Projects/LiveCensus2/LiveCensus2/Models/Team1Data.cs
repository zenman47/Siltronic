namespace LiveCensus2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Team1Data : DbContext
    {
        public Team1Data()
            : base("name=Team1Data")
        {
        }

        public virtual DbSet<Hours> LCEN_HOURS { get; set; }
        public virtual DbSet<Roles> LCEN_ROLES { get; set; }
        public virtual DbSet<Shifts> LCEN_SHIFTS { get; set; }
        public virtual DbSet<Team1> LCEN_TEAM1 { get; set; }
        public virtual DbSet<Users> LCEN_USERS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hours>()
                .Property(e => e.HOUR_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<Hours>()
                .Property(e => e.HRNUM)
                .IsUnicode(false);

            modelBuilder.Entity<Hours>()
                .Property(e => e.HRDISP)
                .IsUnicode(false);

            modelBuilder.Entity<Hours>()
                .Property(e => e.SHIFT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<Hours>()
                .HasMany(e => e.LCEN_TEAM1)
                .WithOptional(e => e.LCEN_HOURS)
                .HasForeignKey(e => e.HOUR);

            modelBuilder.Entity<Roles>()
                .Property(e => e.ROLE_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<Roles>()
                .Property(e => e.DESCR)
                .IsUnicode(false);

            modelBuilder.Entity<Roles>()
                .HasMany(e => e.LCEN_USERS)
                .WithOptional(e => e.LCEN_ROLES)
                .HasForeignKey(e => e.USER_ROLE);

            modelBuilder.Entity<Shifts>()
                .Property(e => e.SHIFT_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<Shifts>()
                .Property(e => e.SHIFTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<Shifts>()
                .Property(e => e.SHIFTDISP)
                .IsUnicode(false);

            modelBuilder.Entity<Shifts>()
                .HasMany(e => e.LCEN_HOURS)
                .WithOptional(e => e.LCEN_SHIFTS)
                .HasForeignKey(e => e.SHIFT);

            modelBuilder.Entity<Shifts>()
                .HasMany(e => e.LCEN_TEAM1)
                .WithOptional(e => e.LCEN_SHIFTS)
                .HasForeignKey(e => e.SHIFT);

            modelBuilder.Entity<Team1>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<Team1>()
                .Property(e => e.HOUR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<Team1>()
                .Property(e => e.SHIFT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<Team1>()
                .Property(e => e.CREATEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<Team1>()
                .Property(e => e.EDITEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<Team1>()
                .Property(e => e.CELL1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<Team1>()
                .Property(e => e.CELL2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<Team1>()
                .Property(e => e.CELL3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<Team1>()
                .Property(e => e.CELL4)
                .HasPrecision(38, 0);

            modelBuilder.Entity<Team1>()
                .Property(e => e.CELL6)
                .HasPrecision(38, 0);

            modelBuilder.Entity<Team1>()
                .Property(e => e.CELL7)
                .HasPrecision(38, 0);

            modelBuilder.Entity<Users>()
                .Property(e => e.USERID)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.FIRST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.LAST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.FULL_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.USER_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.USER_ROLE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<Users>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.LCEN_TEAM1)
                .WithOptional(e => e.LCEN_USERS)
                .HasForeignKey(e => e.CREATEDBY);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.LCEN_TEAM11)
                .WithOptional(e => e.LCEN_USERS1)
                .HasForeignKey(e => e.EDITEDBY);
        }
    }
}
