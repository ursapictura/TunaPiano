using TunaPiano.Models;

namespace TunaPiano.Data
{
    public class SongData
    {
        public static List<Song> Songs = new()
        {
            new Song
            {
                Id = 1,
                Title= "Jolene",
                ArtistId = 2,
                Album = "Jolene",
                Length = 2.42M,
            },

            new Song
            {
                Id = 2,
                Title= "Four Winds",
                ArtistId = 1,
                Album = "Cassadega",
                Length = 4.16M,
            },

            new Song
            {
                Id = 3,
                Title= "Hot Knife",
                ArtistId = 5,
                Album = "The Idler Wheel...",
                Length = 4.02M,
            },

            new Song
            {
                Id = 4,
                Title= "Lazarus",
                ArtistId = 5,
                Album = "Blackstar",
                Length = 6.22M,
            },

            new Song
            {
                Id = 5,
                Title= "Five Years",
                ArtistId = 5,
                Album = "The Rise and Fall of Ziggy Stardust...",
                Length = 4.42M,
            },

            new Song
            {
                Id = 6,
                Title= "Afterthought",
                ArtistId = 1,
                Album = "Salutations",
                Length = 3.35M,
            },

            new Song
            {
                Id = 7,
                Title= "9 to 5",
                ArtistId = 2,
                Album = "9 to 5 and Odd Jobs",
                Length = 2.43M,
            },

            new Song
            {
                Id = 8,
                Title= "Zombies",
                ArtistId = 1,
                Album = "Awaken, My Love!",
                Length = 4.41M,
            },
        };
    }
}