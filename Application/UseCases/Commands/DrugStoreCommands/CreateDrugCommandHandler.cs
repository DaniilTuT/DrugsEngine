using Application.Interfaces.Repositories.DrugStoreRepositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.DrugStoreCommands;

public class CreateDrugStoreCommandHandler : IRequestHandler<CreateDrugStoreCommand,Unit>
{
    private readonly IDrugStoreWriteRepository _drugStoreWriteRepository;
    public async Task<Unit> Handle(CreateDrugStoreCommand request, CancellationToken cancellationToken)
    {
        await _drugStoreWriteRepository.AddAsync(request.DrugStore,cancellationToken);
        
        return Unit.Value;
    }
}