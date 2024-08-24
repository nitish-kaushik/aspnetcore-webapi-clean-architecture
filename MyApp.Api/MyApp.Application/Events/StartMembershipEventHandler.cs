using MediatR;
using Microsoft.Extensions.Logging;

namespace MyApp.Application.Events;


public class StartMembershipEventHandler
    (ILogger<StartMembershipEventHandler> logger)
    : INotificationHandler<UserCreatedEvent>
{
    public async Task Handle(UserCreatedEvent notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("User created: membership start {UserId}", notification.UserId);

        await Task.Delay(2000, cancellationToken);

        logger.LogInformation("User created: membership {UserId}", notification.UserId);
    }
}
