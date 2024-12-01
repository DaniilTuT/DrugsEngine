using MediatR;

namespace Application.UseCases.Commands.UserProfileCommands;

public record DeleteUserProfileCommand(Guid Id) : IRequest<Unit>;