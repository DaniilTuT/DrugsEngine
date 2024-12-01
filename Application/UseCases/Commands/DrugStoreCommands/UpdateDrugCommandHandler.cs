using Application.Interfaces.Repositories.DrugStoreRepositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.DrugStoreCommands;

public class UpdateDrugStoreCommandHandler : IRequestHandler<UpdateDrugStoreCommand,Unit>
{
    private readonly IDrugStoreWriteRepository _drugStoreWriteRepository;
    public async Task<Unit> Handle(UpdateDrugStoreCommand request, CancellationToken cancellationToken)
    {
        await _drugStoreWriteRepository.UpdateAsync(request.DrugStore, cancellationToken);
        return Unit.Value; 
    }
}