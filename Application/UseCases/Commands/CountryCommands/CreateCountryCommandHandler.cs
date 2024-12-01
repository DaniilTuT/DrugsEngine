using Application.Interfaces.Repositories.CountryRepositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.CountryCommands;

public class CreateCountryCommandHandler : IRequestHandler<CreateCountryCommand,Unit>
{
    private readonly ICountryWriteRepository _countryWriteRepository;
    public async Task<Unit> Handle(CreateCountryCommand request, CancellationToken cancellationToken)
    {
        await _countryWriteRepository.AddAsync(request.Country,cancellationToken);
        
        return Unit.Value;
    }
}