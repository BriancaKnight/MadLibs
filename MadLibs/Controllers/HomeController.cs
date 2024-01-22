using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/blankStory")]
    public ActionResult BlankStory() { return View(); }

    [Route("/finalStory")]
    public ActionResult FinalStory()
    {
      FinalStoryVariable myFinalStoryVariable = new FinalStoryVariable();
      myFinalStoryVariable.Adjective1 = "word";
      myFinalStoryVariable.Adjective2 = "word";
      myFinalStoryVariable.Adjective3 = "word";
      myFinalStoryVariable.Adjective4 = "word";
      myFinalStoryVariable.ProperNoun1 = "word";
      myFinalStoryVariable.ProperNoun2 = "word";
      myFinalStoryVariable.ProperNoun3 = "word";
      myFinalStoryVariable.Verb1 = "word";
      myFinalStoryVariable.Verb2 = "word";
      myFinalStoryVariable.Noun = "word";
      return View(myFinalStoryVariable);
    }

    // [Route("/")]
    // public string HomePage() { return "Home"; }
  }
}