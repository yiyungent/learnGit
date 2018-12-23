using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using learnGit.Controllers;

namespace learnGit.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : learnGitControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
