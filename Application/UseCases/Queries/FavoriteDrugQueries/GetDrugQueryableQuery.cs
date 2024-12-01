using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.OData.Query;

namespace Application.UseCases.Queries.FavoriteDrugQueries;


public record GetFavoriteDrugQueryableQuery(ODataQueryOptions<FavoriteDrug> QueryOptions) : IRequest<IQueryable<FavoriteDrug>>;