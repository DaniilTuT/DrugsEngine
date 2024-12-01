using Application.Interfaces.Repositories.DrugRepositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.DrugCommands;

public class DeleteDrugCommandHandler: IRequestHandler<DeleteDrugCommand,Unit>
{
    private readonly IDrugWriteRepository _drugWriteRepository;
    public async Task<Unit> Handle(DeleteDrugCommand request, CancellationToken cancellationToken)
    {
        await _drugWriteRepository.DeleteAsync(request.Id, cancellationToken);
        return Unit.Value;
    }
}