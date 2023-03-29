using JokeApplications.API.Models.Dto;

namespace JokeApplications.Repository
{
    public interface IJokeRepository
    {
        Task<IEnumerable<JokeDto>> GetAllJokes(int? count=0);
        Task<JokeDto> GetJokeById(int jokeId);
        Task<IEnumerable<JokeDto>> GetJokeByType(string type);
        Task<IEnumerable<JokeDto>> GetJokeBySearch(string searchTerm);
        Task<int> GetJokeCunt();
    }
}
