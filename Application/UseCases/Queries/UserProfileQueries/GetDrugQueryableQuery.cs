using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.OData.Query;

namespace Application.UseCases.Queries.UserProfileQueries;


public record GetUserProfileQueryableQuery(ODataQueryOptions<UserProfile> QueryOptions) : IRequest<IQueryable<UserProfile>>;