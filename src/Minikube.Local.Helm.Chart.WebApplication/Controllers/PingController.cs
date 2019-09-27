using Microsoft.AspNetCore.Mvc;

namespace Minikube.Local.Helm.Chart.WebApplication.Controllers
{
    [Route("[Controller]")]
    public class PingController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return NoContent();
        }
    }
}