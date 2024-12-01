using Domain.Entities;
using MediatR;

namespace Application.UseCases.Queries.UserProfileQueries;

public record GetUserProfileByIdQuery(Guid Id) : IRequest<UserProfile?> ;