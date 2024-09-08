using System.Net.NetworkInformation;

namespace TunaPiano.APIs
{ 
    public class ArtistAPI
    {
        public static void Map(WebApplication app)
        {
            //get all Artists
            app.MapGet("api/artists", (TunaPianoDbContext db) =>
            {
                return db.Artists.ToList();
            });
        }
    }
}