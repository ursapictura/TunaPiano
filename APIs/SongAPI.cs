using System.Net.NetworkInformation;

namespace TunaPiano.APIs
{
    public class SongAPI
    {
        public static void Map(WebApplication app)
        {
            //get all Songs
            app.MapGet("api/songs", (TunaPianoDbContext db) =>
            {
                return db.Songs.ToList();
            });
        }
    }
}