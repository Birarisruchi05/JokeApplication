using JokeApplication.Web.Models;
using JokeApplication.Web.Repository.IService;

namespace JokeApplication.Web.Repository
{
    public class JokeService : BaseService, IJokeService
    {
        public IHttpClientFactory _clientFactory;

        public JokeService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<T> GetAllJokesAsync<T>(int? count = 0)
        {
            return await SendAsync<T>(new ApiRequest
            {
                ApiType = SD.ApiType.GET,
                Data = count,
                Url = SD.JokeBaseAPI + "api/Joke/GetAllJokes?count="+count,
                AccessToken = ""
            });
        }

        public async Task<T> GetJokeByIdAsync<T>(int jokeId)
        {
            return await SendAsync<T>(new ApiRequest
            {
                ApiType = SD.ApiType.GET,
                Url = SD.JokeBaseAPI + "api/Joke/GetJokeById/" + jokeId,
                AccessToken = ""
            });
        }

        public async Task<T> GetJokeBySearchAsync<T>(string searchTerm)
        {
            return await SendAsync<T>(new ApiRequest
            {
                ApiType = SD.ApiType.GET,
                Url = SD.JokeBaseAPI + "api/Joke/GetJokeBySearc/" + searchTerm,
                AccessToken = ""
            });
        }

        public async Task<T> GetJokeByTypeAsync<T>(string type)
        {
            return await SendAsync<T>(new ApiRequest
            {
                ApiType = SD.ApiType.GET,
                Url = SD.JokeBaseAPI + "api/Joke/GetJokeByType/" + type,
                AccessToken = ""
            });
        }

        public async Task<T> GetJokeCuntAsync<T>()
        {
            return await SendAsync<T>(new ApiRequest
            {
                ApiType = SD.ApiType.GET,
                Url = SD.JokeBaseAPI + "api/Joke/GetJokeCunt/",
                AccessToken = ""
            });
        }
    }
}
