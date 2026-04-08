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

            modelBuilder.Entity<Track>().HasData(new Track[]{
                new Track { Id = 1, Name = "Gangsta's Paradise", Duration = 3.43m, AlbumId = 1, Rating = 4.8m, PlayCount = 2023144212, Lyrics = "As I walk through the valley of the shadow of death\r\nI take a look at my life and realize there's nothin' left\r\n'Cause I've been blastin' and laughin' so long that\r\nEven my momma thinks that my mind is gone\r\nBut I ain't never crossed a man that didn't deserve it\r\nMe be treated like a punk, you know that's unheard of\r\nYou better watch how you talkin' and where you walkin'\r\nOr you and your homies might be lined in chalk\r\nI really hate to trip, but I gotta loc\r\nAs they croak, I see myself in the pistol smoke\r\nFool, I'm the kinda G the little homies wanna be like\r\nOn my knees in the night, sayin' prayers in the streetlight\r\nBeen spendin' most their lives\r\nLivin' in a gangsta's paradise\r\nBeen spendin' most their lives\r\nLivin' in a gangsta's paradise\r\nKeep spendin' most our lives\r\nLivin' in a gangsta's paradise\r\nKeep spendin' most our lives\r\nLivin' in a gangsta's paradise\r\nLook at the situation they got me facing\r\nI can't live a normal life, I was raised by the street\r\nSo I gotta be down with the hood team\r\nToo much television watchin', got me chasing dreams\r\nI'm a educated fool with money on my mind\r\nGot my ten in my hand and a gleam in my eye\r\nI'm a loc'd out gangsta, set trippin' banger\r\nAnd my homies is down, so don't arouse my anger\r\nFool, death ain't nothin' but a heart beat away\r\nI'm livin' life do or die, what can I say?\r\nI'm 23 now but will I live to see 24?\r\nThe way things is going I don't know\r\nTell me why are we so blind to see\r\nThat the ones we hurt are you and me?\r\nBeen spendin' most their lives\r\nLivin' in a gangsta's paradise\r\nBeen spendin' most their lives\r\nLivin' in a gangsta's paradise\r\nKeep spendin' most our lives\r\nLivin' in a gangsta's paradise\r\nKeep spendin' most our lives\r\nLivin' in a gangsta's paradise\r\nPower and the money, money and the power\r\nMinute after minute, hour after hour\r\nEverybody's runnin', but half of them ain't lookin'\r\nIt's going on in the kitchen, but I don't know what's cookin'\r\nThey say I gotta learn, but nobody's here to teach me\r\nIf they can't understand it, how can they reach me?\r\nI guess they can't, I guess they won't\r\nI guess they front, that's why I know my life is out of luck, fool\r\nBeen spendin' most their lives\r\nLivin' in a gangsta's paradise\r\nBeen spendin' most their lives\r\nLivin' in a gangsta's paradise\r\nKeep spendin' most our lives\r\nLivin' in a gangsta's paradise\r\nKeep spendin' most our lives\r\nLivin' in a gangsta's paradise\r\nTell me why are we so blind to see\r\nThat the ones we hurt are you and me?\r\nTell me why are we so blind to see\r\nThat the ones we hurt are you and me?" },
                new Track { Id = 2, Name = "Blueberry Faygo", Duration = 4.01m, AlbumId = 2, Rating = 4.9m, PlayCount = 1697604708, Lyrics = "Damn, Callan (Damn, Callan)\r\nOne bad bitch and she do what I say so (One, gang)\r\nTwo big .40s and a big ass Draco (Two, boom, boom)\r\nThree more millions when you ask how my day go (Three)\r\nPoured up a four, now that blueberry Faygo\r\nOne false move, and we straight to shooting shit\r\nTwo small bands just to take you out real quick (Bands)\r\nThree more hoes, pull up, I'm fucking shit (Three more, gang)\r\nThat's how it goes, big bands, I'm thumbin' shit (That's how it goes)\r\nAyy, one bad bitch and she do what I say so (Yeah, gang)\r\nTwo big .40s and a big ass Draco (Two)\r\nThree more millions when you ask how my day go\r\nPoured up a four, now that blueberry Faygo\r\nOne false move, and we straight to shooting shit\r\nTwo small bands just to take you out real quick (Bands)\r\nThree more hoes, pull up, I'm fucking shit (Three, yeah)\r\nThat's how it goes, big bands, I'm thumbin' shit (Gang)\r\nI'm with my niggas, yeah, we some rockstars\r\nAnd I'm with my nigga, yeah, KK Wokhardt (KK Wokhardt)\r\nThis not my dick, lil' bitch, my Glock hard (Lil' bitch)\r\nStraight to the cash (Cash), I'm a trapstar\r\nStraight to the bag (Bag), I'm that nigga, huh (Uh)\r\nGot me some gas, rollin' up some\r\nPfft, pfft, cash, yeah, I got me some\r\nI ain't fucked her yesterday (Yeah)\r\nI'ma fuck some\r\nOne bad bitch and she do what I say so (One, gang)\r\nTwo big .40s and a big ass Draco (Two, boom, boom)\r\nThree more millions when you ask how my day go (Three)\r\nPoured up a four, now that blueberry Faygo\r\nOne false move, and we straight to shooting shit\r\nTwo small bands just to take you out real quick (Bands)\r\nThree more hoes, pull up, I'm fucking shit (Three more, gang)\r\nThat's how it goes, big bands, I'm thumbin' shit (That's how it goes)\r\n3-0, clip in my Nina (Ooh-ooh)\r\nOn my toes, Gucci, Valentina (Yeah, bitch)\r\nShe on go, your bitch fuck the team, uh (Lil' bitch)\r\n'Cause you know your bitch want a winner (Winner)\r\nI just went back to my city (To my city)\r\nAnd you know they all fuckin' with me (Yeah, yes)\r\nBut it ain't safe, hoes with me (Hoes)\r\nI'ma chase bands 'til they end me\r\nOne bad bitch and she do what I say so (One, gang)\r\nTwo big .40s and a big ass Draco (Two, boom, boom)\r\nThree more millions when you ask how my day go (Three)\r\nPoured up a four, now that blueberry Faygo\r\nOne false move, and we straight to shooting shit\r\nTwo small bands just to take you out real quick (Bands)\r\nThree more hoes, pull up, I'm fucking shit (Three more, gang)\r\nThat's how it goes, big bands, I'm thumbin' shit (That's how it goes)\r\nAyy, one bad bitch, and she do what I say so (Yeah, gang)\r\nTwo big .40s and a big ass Draco (Two)\r\nThree more millions when you ask how my day go\r\nPoured up a four, now that blueberry Faygo\r\nOne false move, and we straight to shooting shit\r\nTwo small bands just to take you out real quick (Bands)\r\nThree more hoes, pull up, I'm fucking shit (Three, yeah)\r\nThat's how it goes, big bands, I'm thumbin' shit (Gang)"},
                new Track { Id = 3, Name = "Sneako", Duration = 3.21m, AlbumId = 2, Rating = 3.8m, PlayCount = 102, Lyrics = null }
            });

            modelBuilder.Entity<Album>().HasData(new Album[]{
                new Album { Id = 1, Name = "Gangsta's Paradise", Release = 2010, Genre = "Rap", ArtistId = 1, Rating = 4.2m },
                new Album { Id = 2, Name = "Faygo", Release = 2015, Genre = "Pop", ArtistId = 2, Rating = 3.9m }
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
