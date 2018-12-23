using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using learnGit.Roles.Dto;
using learnGit.Users.Dto;

namespace learnGit.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
