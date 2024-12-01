using Application.Interfaces.Repositories.UserProfileRepositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.UserProfileCommands;

public class CreateUserProfileCommandHandler : IRequestHandler<CreateUserProfileCommand,Unit>
{
    private readonly IUserProfileWriteRepository _userProfileWriteRepository;
    public async Task<Unit> Handle(CreateUserProfileCommand request, CancellationToken cancellationToken)
    {
        await _userProfileWriteRepository.AddAsync(request.UserProfile,cancellationToken);
        return Unit.Value;
    }
}