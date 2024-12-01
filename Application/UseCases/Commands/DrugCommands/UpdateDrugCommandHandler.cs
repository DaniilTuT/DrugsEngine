using Application.Interfaces.Repositories.DrugRepositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.DrugCommands;

public class UpdateDrugCommandHandler : IRequestHandler<UpdateDrugCommand,Unit>
{
    private readonly IDrugWriteRepository _drugWriteRepository;
    public async Task<Unit> Handle(UpdateDrugCommand request, CancellationToken cancellationToken)
    {
        await _drugWriteRepository.UpdateAsync(request.Drug, cancellationToken);
        return Unit.Value; 
    }
}