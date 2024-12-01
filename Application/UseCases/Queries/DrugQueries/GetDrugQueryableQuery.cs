using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.OData.Query;

namespace Application.UseCases.Queries.DrugQueries;


public record GetDrugQueryableQuery(ODataQueryOptions<Drug> QueryOptions) : IRequest<IQueryable<Drug>>;