using MyApp.Core.Models;

namespace MyApp.Infrastructure.Services
{
    public interface ICoindeskHttpClientService
    {
        Task<CoindeskData> GetData();
    }
}