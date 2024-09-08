using Microsoft.EntityFrameworkCore;
using TunaPiano.Models;
using TunaPiano.Data;

public class TunaPianoDbContext : DbContext
{
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Song> Songs { get ; set; }
    public DbSet<Genre> Genres { get ; set; }
        

        public TunaPianoDbContext(DbContextOptions<TunaPianoDbContext> options) : base(options)
        {
        }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Artist>().HasData(ArtistData.Artists);
        modelBuilder.Entity<Song>().HasData(SongData.Songs);
        modelBuilder.Entity<Genre>().HasData(GenreData.Genres);
    }
}