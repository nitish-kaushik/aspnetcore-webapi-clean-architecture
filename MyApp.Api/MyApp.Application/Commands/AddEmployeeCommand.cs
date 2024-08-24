using MediatR;
using MyApp.Application.Events;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces;

namespace MyApp.Application.Commands
{
    public record AddEmployeeCommand(EmployeeEntity Employee) : IRequest<EmployeeEntity>;


    public class AddEmployeeCommandHandler(IEmployeeRepository employeeRepository, IPublisher mediator)
        : IRequestHandler<AddEmployeeCommand, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            var user = await employeeRepository.AddEmployeeAsync(request.Employee);
            await mediator.Publish(new UserCreatedEvent(user.Id));
            return user;
        }
    }
}
