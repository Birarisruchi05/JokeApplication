namespace JokeApplication.Web.Models
{
    public class Jokedto
    {
        public int Id { get; set; }
        public string SetUp { get; set; }
        public string PunchLine { get; set; }
        public string Type { get; set; }
        public int AutherId { get; set; }
        public AutherDto Auther { get; set; }
        public DateTime Date { get; set; }
        public string ShareableLink { get; set; }
        public bool Approved { get; set; }
        public bool NSFW { get; set; }
    }
}
