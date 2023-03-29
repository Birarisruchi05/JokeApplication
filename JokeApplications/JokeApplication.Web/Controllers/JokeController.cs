using JokeApplication.Web.Models;
using JokeApplication.Web.Repository.IService;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace JokeApplication.Web.Controllers
{
    public class JokeController : Controller
    {
        private readonly IJokeService _jokeService;

        public JokeController(IJokeService jokeService)
        {
            _jokeService = jokeService;
        }
        public async Task<IActionResult> JokeIndex(int count=0)
        {
            List<Jokedto> list = new();
            var response = await _jokeService.GetAllJokesAsync<ResponseDto>(count);
            if (response != null && response.Susccess == true)
            {
                list = JsonConvert.DeserializeObject<List<Jokedto>>(Convert.ToString(response.Body));
            }
            return View(list);
        }
    }
}
