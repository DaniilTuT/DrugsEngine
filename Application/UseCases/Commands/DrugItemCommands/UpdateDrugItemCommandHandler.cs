using Application.Interfaces.Repositories.DrugItemRepositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.DrugItemCommands;

public class UpdateDrugItemCommandHandler : IRequestHandler<UpdateDrugItemCommand,Unit>
{
    private readonly IDrugItemWriteRepository _drugItemWriteRepository;
    public async Task<Unit> Handle(UpdateDrugItemCommand request, CancellationToken cancellationToken)
    {
        await _drugItemWriteRepository.UpdateAsync(request.DrugItem, cancellationToken);
        return Unit.Value; 
    }
}