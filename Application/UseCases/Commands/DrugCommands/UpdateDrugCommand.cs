using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.DrugCommands;

public record UpdateDrugCommand(Drug Drug) : IRequest<Unit>;