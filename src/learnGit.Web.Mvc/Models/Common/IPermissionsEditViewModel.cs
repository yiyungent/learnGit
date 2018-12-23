using System.Collections.Generic;
using learnGit.Roles.Dto;

namespace learnGit.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}