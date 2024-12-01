using Application.Interfaces.Repositories;
using Application.Interfaces.Repositories.DrugRepositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Queries.DrugQueries;

public class GetDrugByIdQueryHandler: IRequestHandler<GetDrugByIdQuery,Drug?>
{
    private readonly IDrugReadRepository _drugReadRepository;
    public async Task<Drug?> Handle(GetDrugByIdQuery request, CancellationToken cancellationToken)
    {
        var response = await _drugReadRepository.GetByIdAsync(request.Id,cancellationToken);
        
        return response;
    }
}
//TODO: Для каждой сущности(CountryDrugDrugStore) кроме базовой сделать CRUD , попробовать сделать для DrugItem,FavoriteDrug
//TODO : UpdateDrugCommand
//TODO: read about primary constructor