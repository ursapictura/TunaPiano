using System.ComponentModel.DataAnnotations;
using TunaPiano.Models;

namespace TunaPiano.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Description { get; set; }
        List<Song> Songs { get; set; }
    }
}