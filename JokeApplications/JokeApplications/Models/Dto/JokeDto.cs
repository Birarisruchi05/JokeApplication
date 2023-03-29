namespace JokeApplications.API.Models.Dto
{
    public class JokeDto
    {
        public int Id { get; set; }
        public string SetUp { get; set; }
        public string PunchLine { get; set; }
        public string Type { get; set; }
        public int AutherId { get; set; }
        public Auther Auther { get; set; }
        public DateTime Date { get; set; }
        public string ShareableLink { get; set; }
        public bool Approved { get; set; }
        public bool NSFW { get; set; }
    }
}
