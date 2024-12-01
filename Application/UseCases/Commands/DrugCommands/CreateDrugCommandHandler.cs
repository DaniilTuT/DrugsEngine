using Application.Interfaces.Repositories.DrugRepositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.DrugCommands;

public class CreateDrugCommandHandler : IRequestHandler<CreateDrugCommand,Unit>
{
    private readonly IDrugWriteRepository _drugWriteRepository;
    public async Task<Unit> Handle(CreateDrugCommand request, CancellationToken cancellationToken)
    {
        await _drugWriteRepository.AddAsync(request.Drug,cancellationToken);
        
        return Unit.Value;
    }
}