using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Dz1
{
    internal class DBContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PlaylistTrack> PlaylistTracks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-3F4QO0B\SQLEXPRESS;Database=Music1;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PlaylistTrack>()
                .HasKey(pt => new { pt.PlaylistId, pt.TrackId });

            modelBuilder.Entity<Country>().HasData(new Country[]{
                new Country { Id = 1, Name = "USA" },
                new Country { Id = 2, Name = "UK" }
            });

            modelBuilder.Entity<Artist>().HasData(new Artist[]{
                new Artist { Id = 1, Name = "Dj", Surname = "Bob", CountryId = 1 },
                new Artist { Id = 2, Name = "Lil", Surname = "Jonh", CountryId = 2 }
            });

            modelBuilder.Entity<Album>().HasData(new Album[]{
                new Album { Id = 1, Name = "C01234", Release = 2010, Genre = "Rap", ArtistId = 1 },
                new Album { Id = 2, Name = "C56789", Release = 2015, Genre = "Pop", ArtistId = 2 }
            });

            modelBuilder.Entity<Track>().HasData(new Track[]{
                new Track { Id = 1, Name = "Rap", Duration = 3.43m, AlbumId = 1 },
                new Track { Id = 2, Name = "Song", Duration = 4.01m, AlbumId = 2 }
            });

            modelBuilder.Entity<Category>().HasData(new Category[]{
                new Category { Id = 1, Name = "Rap" },
                new Category { Id = 2, Name = "Pop" }
            });

            modelBuilder.Entity<Playlist>().HasData(new Playlist[]{
                new Playlist { Id = 1, Name = "My Playlist 1", CategoryId = 1 },
                new Playlist { Id = 2, Name = "My Playlist 2", CategoryId = 2 }
            });

            modelBuilder.Entity<PlaylistTrack>().HasData(new PlaylistTrack[]{
                new PlaylistTrack { PlaylistId = 1, TrackId = 1 },
                new PlaylistTrack { PlaylistId = 1, TrackId = 2 }
            });
        }
    }
}
