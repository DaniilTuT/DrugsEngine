using Application.Interfaces.Repositories.FavoriteDrugRepositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.FavoriteDrugCommands;

public class DeleteFavoriteDrugCommandHandler: IRequestHandler<DeleteFavoriteDrugCommand,Unit>
{
    private readonly IFavoriteDrugWriteRepository _favoriteDrugWriteRepository;
    public async Task<Unit> Handle(DeleteFavoriteDrugCommand request, CancellationToken cancellationToken)
    {
        await _favoriteDrugWriteRepository.DeleteAsync(request.Id, cancellationToken);
        return Unit.Value;
    }
}