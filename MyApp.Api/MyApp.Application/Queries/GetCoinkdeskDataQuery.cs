using MediatR;
using MyApp.Core.Interfaces;
using MyApp.Core.Models;

namespace MyApp.Application.Queries
{
    public record GetCoinkdeskDataQuery() : IRequest<CoindeskData>;
    public class GetCoinkdeskDataQueryHandler(IExternalVendorRepository externalVendorRepository)
        : IRequestHandler<GetCoinkdeskDataQuery, CoindeskData>
    {
        public async Task<CoindeskData> Handle(GetCoinkdeskDataQuery request, CancellationToken cancellationToken)
        {
            return await externalVendorRepository.GetData();
        }
    }
}
