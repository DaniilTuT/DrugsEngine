using Application.Interfaces.Repositories.CountryRepositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.CountryCommands;

public class DeleteCountryCommandHandler: IRequestHandler<DeleteCountryCommand,Unit>
{
    private readonly ICountryWriteRepository _countryWriteRepository;
    public async Task<Unit> Handle(DeleteCountryCommand request, CancellationToken cancellationToken)
    {
        await _countryWriteRepository.DeleteAsync(request.Id, cancellationToken);
        return Unit.Value;
    }
}