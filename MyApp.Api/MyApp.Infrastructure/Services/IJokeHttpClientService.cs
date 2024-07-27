using MyApp.Core.Models;

namespace MyApp.Infrastructure.Services
{
    public interface IJokeHttpClientService
    {
        Task<JokeModel> GetData();
    }
}