namespace JokeApplication.Web.Repository.IService
{
    public interface IJokeService
    {
        Task<T> GetAllJokesAsync<T>(int? count = 0);
        Task<T> GetJokeByIdAsync<T>(int jokeId);
        Task<T> GetJokeByTypeAsync<T>(string type);
        Task<T> GetJokeBySearchAsync<T>(string searchTerm);
        Task<T> GetJokeCuntAsync<T>();
    }
}
