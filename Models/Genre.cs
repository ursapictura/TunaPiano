using System.ComponentModel.DataAnnotations;
using TunaPiano.Models;

namespace TunaPiano.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public List<Song> Songs { get; set; }
    }
}