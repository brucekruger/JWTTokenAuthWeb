using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWTTokenAuthWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [Authorize]
        [Route("getlogin")]
        public IActionResult GetLogin() => Ok($"Your login: {User.Identity.Name}");

        [Authorize(Roles = "admin")]
        [Route("getrole")]
        public IActionResult GetRole() => Ok("Your role: administrator");
    }
}
