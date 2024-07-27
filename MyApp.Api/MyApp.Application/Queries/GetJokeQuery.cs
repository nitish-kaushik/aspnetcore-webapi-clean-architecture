using MediatR;
using MyApp.Core.Interfaces;
using MyApp.Core.Models;

namespace MyApp.Application.Queries
{
    public record GetJokeQuery() : IRequest<JokeModel>;
    public class GetJokeQueryHandler(IExternalVendorRepository externalVendorRepository)
        : IRequestHandler<GetJokeQuery, JokeModel>
    {
        public async Task<JokeModel> Handle(GetJokeQuery request, CancellationToken cancellationToken)
        {
            return await externalVendorRepository.GetJoke();
        }
    }
}
