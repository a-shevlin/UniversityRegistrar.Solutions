using Microsoft.AspNetCore.Mvc;

namespace University.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.PageTitle = ("Registry Home");
      return View();
    }
  }
}