using Microsoft.AspNetCore.Mvc;

namespace Cut_Coffee_Paste.Controllers
{
    public class PostsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
