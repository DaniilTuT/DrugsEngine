using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.CountryCommands;

public record UpdateCountryCommand(Country Country) : IRequest<Unit>;