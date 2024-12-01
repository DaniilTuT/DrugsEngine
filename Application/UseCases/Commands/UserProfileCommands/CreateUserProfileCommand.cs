using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.UserProfileCommands;

public record CreateUserProfileCommand(UserProfile UserProfile) : IRequest<Unit>;