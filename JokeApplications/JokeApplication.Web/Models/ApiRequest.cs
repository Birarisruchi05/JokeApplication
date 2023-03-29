using static JokeApplication.Web.SD;

namespace JokeApplication.Web.Models
{
    public class ApiRequest
    {
        public ApiType ApiType { get; set; } = SD.ApiType.GET;

        public string Url { get; set; }

        public object Data { get; set; }

        public string AccessToken { get; set; }
    }
}
