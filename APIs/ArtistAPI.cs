using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;
using TunaPiano.Models;

namespace TunaPiano.APIs
{ 
    public class ArtistAPI
    {
        public static void Map(WebApplication app)
        {
            //Get all Artists
            app.MapGet("/api/artists", (TunaPianoDbContext db) =>
            {
                return db.Artists.ToList();
            });

            // Get Sinlge Artist by ID
            app.MapGet("/api/artists/{artistId}", (TunaPianoDbContext db, int artistId) =>
            {
                Artist artist = db.Artists
                                .Include(a => a.Songs)
                                .SingleOrDefault(a => a.Id == artistId);
                if (artist == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(artist);
            });

            // Create a new Artist
            app.MapPost("/api/artists", (TunaPianoDbContext db, Artist newArtist) =>
            {
                db.Artists.Add(newArtist);
                db.SaveChanges();
                return Results.Created($"api/artists/{newArtist.Id}", newArtist);
            });

            // Delete an Artist
            app.MapDelete("/api/artists/{artistId}", (TunaPianoDbContext db, int artistId) =>
            {
                Artist artist = db.Artists
                                .SingleOrDefault(a => a.Id == artistId);

                if (artist == null)
                {
                    return Results.NotFound();
                }
                db.Artists.Remove(artist);
                db.SaveChanges();
                return Results.NoContent();
            });

            // Update an Artist
            app.MapPut("/api/artists/{artistId}", (TunaPianoDbContext db, int artistId, Artist artist) =>
            {
                Artist artistToUpdate = db.Artists.SingleOrDefault(a => a.Id == artistId);

                if (artistToUpdate == null )
                {
                    return Results.NotFound();
                }

                artistToUpdate.Name = artist.Name;
                artistToUpdate.Age = artist.Age;
                artistToUpdate.Bio = artist.Bio;

                db.SaveChanges();
                return Results.Ok(artistToUpdate);
            });
        }
    }
}