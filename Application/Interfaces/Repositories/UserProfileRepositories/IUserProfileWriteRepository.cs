using Application.Interfaces.Repositories.BaseRepositories;
using Domain.Entities;

namespace Application.Interfaces.Repositories.UserProfileRepositories;

public interface IUserProfileWriteRepository: IWriteRepository<UserProfile>
{
    
}