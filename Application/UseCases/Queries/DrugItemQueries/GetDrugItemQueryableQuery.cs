using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.OData.Query;

namespace Application.UseCases.Queries.DrugItemQueries;


public record GetDrugItemQueryableQuery(ODataQueryOptions<DrugItem> QueryOptions) : IRequest<IQueryable<DrugItem>>;