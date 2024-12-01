using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.CountryCommands;

public record CreateCountryCommand(Country Country) : IRequest<Unit>;