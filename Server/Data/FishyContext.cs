using System.Data.Entity;

namespace Fishy_Model.Models
{
    public partial class FishyContext : DbContext
    {
        public FishyContext(): base("name=FishyContext"){ }
        public virtual DbSet<ALBUM> ALBUMS { get; set; }
        public virtual DbSet<COMMENT> COMMENTS { get; set; }
        public virtual DbSet<DIALOG> DIALOGS { get; set; }
        public virtual DbSet<FISH> FISHES { get; set; }
        public virtual DbSet<FRIEND> FRIENDS { get; set; }
        public virtual DbSet<MESSAGE> MESSAGES { get; set; }
        public virtual DbSet<NEWS> NEWS { get; set; }
        public virtual DbSet<PHOTO> PHOTOS { get; set; }
        public virtual DbSet<STATE_INSPECTION> STATE_INSPECTIONS { get; set; }
        public virtual DbSet<USER> USERS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ALBUM>()
                .HasMany(e => e.PHOTOS)
                .WithOptional(e => e.ALBUM1)
                .HasForeignKey(e => e.ALBUM);

            modelBuilder.Entity<DIALOG>()
                .HasMany(e => e.MESSAGES)
                .WithOptional(e => e.DIALOG1)
                .HasForeignKey(e => e.DIALOG);

            modelBuilder.Entity<PHOTO>()
                .HasMany(e => e.COMMENTS)
                .WithOptional(e => e.Photo1)
                .HasForeignKey(e => e.PHOTO);

            modelBuilder.Entity<USER>()
                .HasMany(e => e.ALBUMS)
                .WithOptional(e => e.USER)
                .HasForeignKey(e => e.OWNER);

            modelBuilder.Entity<USER>()
                .HasMany(e => e.COMMENTS)
                .WithOptional(e => e.USER)
                .HasForeignKey(e => e.SENDER);

            modelBuilder.Entity<USER>()
                .HasMany(e => e.DIALOGS)
                .WithOptional(e => e.USER)
                .HasForeignKey(e => e.USER1);

            modelBuilder.Entity<USER>()
                .HasMany(e => e.DIALOGS1)
                .WithOptional(e => e.USER3)
                .HasForeignKey(e => e.USER2);

            modelBuilder.Entity<USER>()
                .HasMany(e => e.FRIENDS)
                .WithOptional(e => e.USER)
                .HasForeignKey(e => e.ID1);

            modelBuilder.Entity<USER>()
                .HasMany(e => e.FRIENDS1)
                .WithOptional(e => e.USER1)
                .HasForeignKey(e => e.ID2);

            modelBuilder.Entity<USER>()
                .HasMany(e => e.MESSAGES)
                .WithOptional(e => e.USER)
                .HasForeignKey(e => e.SENDER);
        }
    }
}
