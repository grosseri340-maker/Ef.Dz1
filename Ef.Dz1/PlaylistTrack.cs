namespace Ef.Dz1
{
    public class PlaylistTrack
    {
        public Playlist Playlist { get; set; }
        public int PlaylistId { get; set; }
        public Track Track { get; set; }
        public int TrackId { get; set; }
    }
}
