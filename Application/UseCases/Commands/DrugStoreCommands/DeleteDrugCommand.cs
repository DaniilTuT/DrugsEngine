using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.DrugStoreCommands;

public record DeleteDrugStoreCommand(Guid Id) : IRequest<Unit>;