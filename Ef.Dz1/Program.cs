using System;

namespace Ef.Dz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DBContext())
            {
                db.Database.EnsureCreated();
            }
        }
    }
}