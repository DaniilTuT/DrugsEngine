using Application.Interfaces.Repositories.DrugItemRepositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.DrugItemCommands;

public class CreateDrugItemCommandHandler : IRequestHandler<CreateDrugItemCommand,Unit>
{
    private readonly IDrugItemWriteRepository _drugWriteRepository;
    public async Task<Unit> Handle(CreateDrugItemCommand request, CancellationToken cancellationToken)
    {
        await _drugWriteRepository.AddAsync(request.DrugItem,cancellationToken);
        return Unit.Value;
    }
}