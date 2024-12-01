using Application.Interfaces.Repositories.FavoriteDrugRepositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.FavoriteDrugCommands;

public class UpdateFavoriteDrugCommandHandler : IRequestHandler<UpdateFavoriteDrugCommand,Unit>
{
    private readonly IFavoriteDrugWriteRepository _favoriteDrugWriteRepository;
    public async Task<Unit> Handle(UpdateFavoriteDrugCommand request, CancellationToken cancellationToken)
    {
        await _favoriteDrugWriteRepository.UpdateAsync(request.FavoriteDrug, cancellationToken);
        return Unit.Value; 
    }
}