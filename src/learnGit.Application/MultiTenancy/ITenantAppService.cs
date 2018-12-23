using Abp.Application.Services;
using Abp.Application.Services.Dto;
using learnGit.MultiTenancy.Dto;

namespace learnGit.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

