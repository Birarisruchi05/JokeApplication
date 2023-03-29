using JokeApplication.Web.Models;

namespace JokeApplication.Web.Repository.IService
{
    public interface IBaseService
    {
        ResponseDto responseModel { get; set; }

        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
