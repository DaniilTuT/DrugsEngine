using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.DrugStoreCommands;

public record UpdateDrugStoreCommand(DrugStore DrugStore) : IRequest<Unit>;