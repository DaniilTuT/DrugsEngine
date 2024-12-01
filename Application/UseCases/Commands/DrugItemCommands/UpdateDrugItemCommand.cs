using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.DrugItemCommands;

public record UpdateDrugItemCommand(DrugItem DrugItem) : IRequest<Unit>;