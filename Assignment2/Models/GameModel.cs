namespace assignment.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GameModel : DbContext
    {
        public GameModel()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Collection> Collections { get; set; }
        public virtual DbSet<Designer> Designers { get; set; }
        public virtual DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Collection>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Designer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Game>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Game>()
                .Property(e => e.Description)
                .IsUnicode(false);
        }
    }
}
