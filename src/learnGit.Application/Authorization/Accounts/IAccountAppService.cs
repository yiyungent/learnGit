using System.Threading.Tasks;
using Abp.Application.Services;
using learnGit.Authorization.Accounts.Dto;

namespace learnGit.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
