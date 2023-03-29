using System.ComponentModel.DataAnnotations;

namespace JokeApplications.API.Models
{
    public class Auther
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
