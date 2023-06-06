using Microsoft.EntityFrameworkCore;

namespace WebApi_Project
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //For Seed Data
            modelBuilder.Entity<Music>()
                 .HasData(
                new Music() { Id = 1 , Name = "Dip" , Musician = "Madrigal"},
                new Music() { Id = 2 , Name = "Seni Dert Etmeler" , Musician = "Madrigal"},
                new Music() { Id = 3 , Name = "Gözlerin" , Musician = "Barış Akarsu"},
                new Music() { Id = 4 , Name="Gözlerimin Etrafındaki Çizgiler" , Musician = "Şebnem Ferah"}
                );
        }

        public DbSet<Music> Musics { get; set; }
    }
}
