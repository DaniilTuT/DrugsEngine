using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.DrugItemCommands;

public record CreateDrugItemCommand(DrugItem DrugItem) : IRequest<Unit>;