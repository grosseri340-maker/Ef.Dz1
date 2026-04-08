using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Dz1
{
    internal class MusicCollection
    {
        DBContext db = new DBContext();
        public MusicCollection() { }
        public void ShowTracksAboveAvg(int albumId)
        {
            var avgPC = db.Tracks
                .Where(t => t.AlbumId == albumId)
                .Average(t => t.PlayCount);

            var tracks = db.Tracks
                .Where(t => t.AlbumId == albumId && t.PlayCount > avgPC)
                .Select(t => new
                {
                    t.Name,
                    t.PlayCount
                })
                .ToList();

            Console.WriteLine("\nTracks with listens above average:");

            foreach (var t in tracks)
            {
                Console.WriteLine($"{t.Name} - {t.PlayCount}");
            }
        }

        public void ShowTopThree(int artistId)
        {
            var topTracks = db.Tracks
                .Where(t => t.Album.ArtistId == artistId)
                .OrderByDescending(t => t.Rating)
                .Take(3)
                .Select(t => new
                {
                    t.Name,
                    t.Rating
                })
                .ToList();

            var topAlbums = db.Albums
                .Where(a => a.ArtistId == artistId)
                .OrderByDescending(a => a.Rating)
                .Take(3)
                .Select(a => new
                {
                    a.Name,
                    a.Rating
                })
                .ToList();

            Console.WriteLine("\n=====Top 3 Tracks=====");
            foreach (var t in topTracks)
            {
                Console.WriteLine($"{t.Name} - {t.Rating}");
            }

            Console.WriteLine("\n=====Top 3 Albums=====");
            foreach (var a in topAlbums)
            {
                Console.WriteLine($"{a.Name} - {a.Rating}");
            }
        }
        public void SearchTracks(string str)
        {
            var tracks = db.Tracks
                .Where(t => t.Name.Contains(str) || t.Lyrics != null && t.Lyrics.Contains(str))
                .Select(t => new
                {
                    t.Name,
                    t.Lyrics
                })
                .ToList();

            Console.WriteLine($"\nResults:");

            foreach (var t in tracks)
            {
                Console.WriteLine($"{t.Name}");
            }
        }
    }
}
