using System.Threading.Tasks;
using Abp.Application.Services;
using learnGit.Sessions.Dto;

namespace learnGit.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
