using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.DrugCommands;

public record DeleteDrugCommand(Guid Id) : IRequest<Unit>;