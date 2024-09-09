using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;
using TunaPiano.Models;

namespace TunaPiano.APIs
{
    public class SongAPI
    {
        public static void Map(WebApplication app)
        {
            //get all Songs
            app.MapGet("/api/songs", (TunaPianoDbContext db) =>
            {
                return db.Songs.ToList();
            });

            //Get single Song by ID
            app.MapGet("/api/songs/{songId}", (TunaPianoDbContext db, int songId) =>
            {
                Song song = db.Songs
                                .Include(s => s.Artist)
                                .Include(s => s.Genres)
                                .SingleOrDefault(s => s.Id == songId);
                if (song == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(song);
            });

            // Create a new Song
            app.MapPost("/api/songs", (TunaPianoDbContext db, Song newSong) =>
            {
                db.Songs.Add(newSong);
                db.SaveChanges();
                return Results.Created($"api/songs/{newSong.Id}", newSong);
            });

            // Delete a Song
            app.MapDelete("/api/songs/{SongId}", (TunaPianoDbContext db, int songId) =>
            {
                Song song = db.Songs
                                .SingleOrDefault(s => s.Id == songId);

                if (song == null)
                {
                    return Results.NotFound();
                }
                db.Songs.Remove(song);
                db.SaveChanges();
                return Results.NoContent();
            });

            // Update a Song
            app.MapPut("/api/songs/{songId}", (TunaPianoDbContext db, int songId, Song song) =>
            {
                Song songToUpdate = db.Songs.SingleOrDefault(s => s.Id == songId);

                if (songToUpdate == null)
                {
                    return Results.NotFound();
                }

                songToUpdate.Title = song.Title;
                songToUpdate.ArtistId = song.ArtistId;
                songToUpdate.Album = song.Album;
                songToUpdate.Length = song.Length;

                db.SaveChanges();
                return Results.Ok(songToUpdate);
            });
        }
    }
}