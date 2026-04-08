using Microsoft.EntityFrameworkCore;
using System;

namespace Ef.Dz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DBContext())
            {
                db.Database.Migrate();

                MusicCollection mc = new MusicCollection();

                mc.ShowTracksAboveAvg(2);
                mc.ShowTopThree(2);
                mc.SearchTracks("spendin");
            }
        }
    }
}