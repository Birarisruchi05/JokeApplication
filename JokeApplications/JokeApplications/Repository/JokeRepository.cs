using AutoMapper;
using JokeApplications.API.Context;
using JokeApplications.API.Models;
using JokeApplications.API.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace JokeApplications.Repository
{
    public class JokeRepository : IJokeRepository
    {
        private readonly ApplicationDBContext _dbContext;
        private IMapper _mapper;

        public JokeRepository(ApplicationDBContext dBContext, IMapper mapper)
        {
            _dbContext = dBContext;
            _mapper = mapper;

        }
        public async Task<IEnumerable<JokeDto>> GetAllJokes(int? count = 0)
        {
            List<Joke> jokeList = null;
            if (count == 0)
            {
                jokeList = await _dbContext.Jokes.ToListAsync();
            }
            else
            {
                jokeList = await _dbContext.Jokes.Take((int)count).ToListAsync();
            }            
            return _mapper.Map<List<JokeDto>>(jokeList);
        }

        public async Task<JokeDto> GetJokeById(int jokeId)
        {
            Joke joke = await _dbContext.Jokes.Where(x => x.Id == jokeId).FirstOrDefaultAsync();
            return _mapper.Map<JokeDto>(joke);
        }

        public async Task<IEnumerable<JokeDto>> GetJokeBySearch(string searchTerm)
        {
            List<Joke> jokeList = await _dbContext.Jokes.Where(x=>x.SetUp.Contains(searchTerm)).ToListAsync();
            return _mapper.Map<List<JokeDto>>(jokeList);
        }

        public async Task<IEnumerable<JokeDto>> GetJokeByType(string type)
        {
            List<Joke> jokeList = await _dbContext.Jokes.Where(x => x.Type== type).ToListAsync();
            return _mapper.Map<List<JokeDto>>(jokeList);
        }

        public async Task<int> GetJokeCunt()
        {
            int count = await _dbContext.Jokes.CountAsync();
            return count;
        }
    }
}
