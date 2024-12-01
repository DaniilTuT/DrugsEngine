using MediatR;

namespace Application.UseCases.Commands.FavoriteDrugCommands;

public record DeleteFavoriteDrugCommand(Guid Id) : IRequest<Unit>;