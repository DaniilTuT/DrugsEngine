using Application.Interfaces.Repositories.FavoriteDrugRepositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.FavoriteDrugCommands;

public class CreateFavoriteDrugCommandHandler : IRequestHandler<CreateFavoriteDrugCommand,Unit>
{
    private readonly IFavoriteDrugWriteRepository _favoriteDrugWriteRepository;
    public async Task<Unit> Handle(CreateFavoriteDrugCommand request, CancellationToken cancellationToken)
    {
        await _favoriteDrugWriteRepository.AddAsync(request.FavoriteDrug,cancellationToken);
        
        return Unit.Value;
    }
}