using Application.Interfaces.Repositories.UserProfileRepositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.UserProfileCommands;

public class UpdateUserProfileCommandHandler : IRequestHandler<UpdateUserProfileCommand,Unit>
{
    private readonly IUserProfileWriteRepository _userProfileWriteRepository;
    public async Task<Unit> Handle(UpdateUserProfileCommand request, CancellationToken cancellationToken)
    {
        await _userProfileWriteRepository.UpdateAsync(request.UserProfile, cancellationToken);
        return Unit.Value; 
    }
}