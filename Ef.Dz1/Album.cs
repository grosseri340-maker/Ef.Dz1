namespace Ef.Dz1
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Release { get; set; }
        public string Genre { get; set; }
        public Artist Artist { get; set; }
        public int ArtistId { get; set; }
        public decimal Rating { get; set; }
        public ICollection<Track> Tracks { get; set; }
    }
}
