using JokeApplications.API.Models.Dto;
using JokeApplications.Models.Dto;
using JokeApplications.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JokeApplications.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JokeController : ControllerBase
    {
        protected ResponseDto _respose;
        private IJokeRepository _jokeRepository;

        public JokeController(IJokeRepository jokeRepository)
        {
            _jokeRepository = jokeRepository;
            _respose = new ResponseDto();
        }

        [HttpGet]
        [Route("GetAllJokes")]
        public async Task<object> GetAllJokes(int? count=0)
        {
            try
            {
                IEnumerable<JokeDto> jokeDto = await _jokeRepository.GetAllJokes(count);
                _respose.Body = jokeDto;
            }
            catch (Exception ex)
            {
                _respose.Susccess = false;
               
            }
            return _respose;
        }

        [HttpGet]
        [Route("GetJokeById/{id}")]
        public async Task<object> GetJokeById(int id)
        {
            try
            {
                JokeDto  jokeDto = await _jokeRepository.GetJokeById(id);
                _respose.Body = jokeDto;
            }
            catch (Exception ex)
            {
                _respose.Susccess = false;

            }
            return _respose;
        }
        [HttpGet]
        [Route("GetJokeByType/{type}")]
        public async Task<object> GetJokeByType(string type)
        {
            try
            {
                IEnumerable<JokeDto> jokeDto = await _jokeRepository.GetJokeByType(type);
                _respose.Body = jokeDto;
            }
            catch (Exception ex)
            {
                _respose.Susccess = false;

            }
            return _respose;
        }
        [HttpGet]
        [Route("GetJokeBySearch/{serachTerm}")]
        public async Task<object> GetJokeBySearch(string serachTerm)
        {
            try
            {
                IEnumerable<JokeDto> jokeDto = await _jokeRepository.GetJokeBySearch(serachTerm);
                _respose.Body = jokeDto;
            }
            catch (Exception ex)
            {
                _respose.Susccess = false;

            }
            return _respose;
        }
        [HttpGet]
        [Route("GetJokeCunt")]
        public async Task<object> GetJokeCunt()
        {
            try
            {
                int count = await _jokeRepository.GetJokeCunt();
                _respose.Body = count;
            }
            catch (Exception ex)
            {
                _respose.Susccess = false;

            }
            return _respose;
        }
    }
}
