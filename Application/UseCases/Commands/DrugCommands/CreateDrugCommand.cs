using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.DrugCommands;

public record CreateDrugCommand(Drug Drug) : IRequest<Unit>;