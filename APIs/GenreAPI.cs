using System.Net.NetworkInformation;

namespace TunaPiano.APIs
{
    public class GenreAPI
    {
        public static void Map(WebApplication app)
        {
            //get all Genres
            app.MapGet("api/genres", (TunaPianoDbContext db) =>
            {
                return db.Genres.ToList();
            });
        }
    }
}