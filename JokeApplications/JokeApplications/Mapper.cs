using AutoMapper;
using JokeApplications.API.Models;
using JokeApplications.API.Models.Dto;
using System.Net;
using System.Reflection;

namespace JokeApplications.API
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Joke, JokeDto>().ReverseMap();
            CreateMap<Auther, AutherDto>().ReverseMap();
        }
    }
}
