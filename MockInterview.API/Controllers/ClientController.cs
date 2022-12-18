using Microsoft.AspNetCore.Mvc;

namespace MockInterview.API.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
