using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.DrugItemCommands;

public record DeleteDrugItemCommand(Guid Id) : IRequest<Unit>;