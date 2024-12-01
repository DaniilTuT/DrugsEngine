using Application.Interfaces.Repositories.CountryRepositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.CountryCommands;

public class UpdateCountryCommandHandler : IRequestHandler<UpdateCountryCommand,Unit>
{
    private readonly ICountryWriteRepository _countryWriteRepository;
    public async Task<Unit> Handle(UpdateCountryCommand request, CancellationToken cancellationToken)
    {
        await _countryWriteRepository.UpdateAsync(request.Country, cancellationToken);
        return Unit.Value; 
    }
}