using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.FavoriteDrugCommands;

public record CreateFavoriteDrugCommand(FavoriteDrug FavoriteDrug) : IRequest<Unit>;