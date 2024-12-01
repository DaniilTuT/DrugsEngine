using Application.Interfaces.Repositories.DrugStoreRepositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.DrugStoreCommands;

public class DeleteDrugStoreCommandHandler: IRequestHandler<DeleteDrugStoreCommand,Unit>
{
    private readonly IDrugStoreWriteRepository _drugStoreWriteRepository;
    public async Task<Unit> Handle(DeleteDrugStoreCommand request, CancellationToken cancellationToken)
    {
        await _drugStoreWriteRepository.DeleteAsync(request.Id, cancellationToken);
        return Unit.Value;
    }
}