using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.UserProfileCommands;

public record UpdateUserProfileCommand(UserProfile UserProfile) : IRequest<Unit>;