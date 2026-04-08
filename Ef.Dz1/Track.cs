namespace Ef.Dz1
{
    public class Track
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Duration { get; set; }
        public decimal Rating { get; set; }
        public int PlayCount { get; set; }
        public string? Lyrics { get; set; }
        public Album Album { get; set; }
        public int AlbumId { get; set; }
        public ICollection<PlaylistTrack> PlaylistTracks { get; set; }
    }
}
