using Microsoft.AspNetCore.Antiforgery;
using learnGit.Controllers;

namespace learnGit.Web.Host.Controllers
{
    public class AntiForgeryController : learnGitControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
