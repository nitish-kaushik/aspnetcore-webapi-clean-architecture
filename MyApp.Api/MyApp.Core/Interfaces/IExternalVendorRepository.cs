
using MyApp.Core.Models;

namespace MyApp.Core.Interfaces;
public interface IExternalVendorRepository
{
    Task<CoindeskData> GetData();
    Task<JokeModel> GetJoke();
}