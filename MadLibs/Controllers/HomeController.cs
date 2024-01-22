using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/blankStory")]
    public ActionResult BlankStory() { return View(); }

    [Route("/finalStory")]
    public string FinalStory() { return "Here is the completed story"; }
    // [Route("/")]
    // public string HomePage() { return "Home"; }
  }
}