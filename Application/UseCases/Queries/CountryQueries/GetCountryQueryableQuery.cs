using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.OData.Query;

namespace Application.UseCases.Queries.CountryQueries;


public record GetCountryQueryableQuery(ODataQueryOptions<Country> QueryOptions) : IRequest<IQueryable<Country>>;