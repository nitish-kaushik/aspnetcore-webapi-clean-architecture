using MediatR;

namespace MyApp.Application.Events;

public record UserCreatedEvent(Guid UserId) : INotification;
