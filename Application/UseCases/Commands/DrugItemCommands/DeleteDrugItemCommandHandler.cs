using Application.Interfaces.Repositories.DrugItemRepositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.DrugItemCommands;

public class DeleteDrugItemCommandHandler: IRequestHandler<DeleteDrugItemCommand,Unit>
{
    private readonly IDrugItemWriteRepository _drugItemWriteRepository;
    public async Task<Unit> Handle(DeleteDrugItemCommand request, CancellationToken cancellationToken)
    {
        await _drugItemWriteRepository.DeleteAsync(request.Id, cancellationToken);
        return Unit.Value;
    }
}