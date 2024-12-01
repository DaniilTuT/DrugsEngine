using Domain.Entities;
using MediatR;

namespace Application.UseCases.Commands.FavoriteDrugCommands;

public record UpdateFavoriteDrugCommand(FavoriteDrug FavoriteDrug) : IRequest<Unit>;