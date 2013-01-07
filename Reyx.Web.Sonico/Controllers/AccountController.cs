using System.Web.Mvc;
using System.Web.Security;

namespace Reyx.Web.Sonico.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login(string userName, string password, string ReturnUrl)
        {
            if (!(string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(password)))
            {
                if (Membership.ValidateUser(userName, password))
                    this.RedirectFromLoginPage(userName, ReturnUrl);
                else
                    this.ViewData["LoginFailed"] = "Usuário ou senha inválidos.";
            }

            return View();
        }

        private void RedirectFromLoginPage(string userName, string ReturnUrl)
        {
            FormsAuthentication.SetAuthCookie(userName, false);

            if (string.IsNullOrWhiteSpace(ReturnUrl))
                Response.Redirect(FormsAuthentication.DefaultUrl);
            else
                Response.Redirect(ReturnUrl);

        }
    }
}