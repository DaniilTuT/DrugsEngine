using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.CountryCommands;

public record DeleteCountryCommand(Guid Id) : IRequest<Unit>;