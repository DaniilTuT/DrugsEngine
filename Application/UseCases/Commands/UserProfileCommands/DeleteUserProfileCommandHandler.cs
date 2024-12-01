using Application.Interfaces.Repositories.UserProfileRepositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.UserProfileCommands;

public class DeleteUserProfileCommandHandler: IRequestHandler<DeleteUserProfileCommand,Unit>
{
    private readonly IUserProfileWriteRepository _userProfileWriteRepository;
    public async Task<Unit> Handle(DeleteUserProfileCommand request, CancellationToken cancellationToken)
    {
        await _userProfileWriteRepository.DeleteAsync(request.Id, cancellationToken);
        return Unit.Value;
    }
}