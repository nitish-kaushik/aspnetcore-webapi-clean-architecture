using MyApp.Core.Interfaces;
using MyApp.Core.Models;
using MyApp.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure.Repositories
{
    public class ExternalVendorRepository(
        ICoindeskHttpClientService coindeskHttpClientService,
        IJokeHttpClientService jokeHttpClientService)
        : IExternalVendorRepository
    {
        public async Task<CoindeskData> GetData()
        {
            return await coindeskHttpClientService.GetData();
        }

        public async Task<JokeModel> GetJoke()
        {
            return await jokeHttpClientService.GetData();
        }
    }
}
