using Microsoft.EntityFrameworkCore;
using System;
using System.Net.NetworkInformation;
using TunaPiano.Models;
using TunaPiano.DTOs;

namespace TunaPiano.APIs
{
    public class GenreAPI
    {
        public static void Map(WebApplication app)
        {
            //Get all Genres
            app.MapGet("/api/genres", (TunaPianoDbContext db) =>
            {
                return db.Genres.ToList();
            });

            // Get Sinlge Genre by ID
            app.MapGet("/api/genres/{genreId}", (TunaPianoDbContext db, int genreId) =>
            {
                Genre genre = db.Genres
                                .Include(g => g.Songs)
                                .SingleOrDefault(g => g.Id == genreId);
                if (genre == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(genre);
            });

            // Create a new Genre
            app.MapPost("/api/genres", (TunaPianoDbContext db, Genre newGenre) =>
            {
                db.Genres.Add(newGenre);
                db.SaveChanges();
                return Results.Created($"api/genres/{newGenre.Id}", newGenre);
            });

            // Delete a Genre
            app.MapDelete("/api/genres/{genreId}", (TunaPianoDbContext db, int genreId) =>
            {
                Genre genre = db.Genres
                                .SingleOrDefault(g => g.Id == genreId);

                if (genre == null)
                {
                    return Results.NotFound();
                }
                db.Genres.Remove(genre);
                db.SaveChanges();
                return Results.NoContent();
            });

            // Update a Genre
            app.MapPut("/api/genres/{genreId}", (TunaPianoDbContext db, int genreId, Genre genre) =>
            {
                Genre genreToUpdate = db.Genres.SingleOrDefault(g => g.Id == genreId);

                if (genreToUpdate == null)
                {
                    return Results.NotFound();
                }

                genreToUpdate.Description = genre.Description;

                db.SaveChanges();
                return Results.Ok(genreToUpdate);
            });

            // Add Genre to a Song
            app.MapPost("/api/genres/addSong", (TunaPianoDbContext db, AddGenreToSongDTO newSong) =>
            {
                var genre = db.Genres
                               .Include(g => g.Songs)
                               .SingleOrDefault(o => o.Id == newSong.GenreId);

                if (genre == null)
                {
                    return Results.NotFound();
                }

                var song = db.Songs
                           .Include(s => s.Genres)
                           .SingleOrDefault(s => s.Id == newSong.SongId);

                if (song == null)
                {
                    return Results.NotFound();
                }

                genre.Songs.Add(song);
                db.SaveChanges();
                return Results.Created($"/api/genres/addSong", newSong);
            });
        }
    }
}