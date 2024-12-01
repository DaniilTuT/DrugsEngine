using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.OData.Query;

namespace Application.UseCases.Queries.DrugStoreQueries;


public record GetDrugStoreQueryableQuery(ODataQueryOptions<DrugStore> QueryOptions) : IRequest<IQueryable<DrugStore>>;