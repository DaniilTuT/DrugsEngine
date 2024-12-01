using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.DrugStoreCommands;

public record CreateDrugStoreCommand(DrugStore DrugStore) : IRequest<Unit>;