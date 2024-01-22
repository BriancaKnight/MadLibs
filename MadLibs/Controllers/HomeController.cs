using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/blankStory")]
    public ActionResult BlankStory() { return View(); }

    [Route("/finalStory")]
    public ActionResult FinalStory(string adjective1, string adjective2, string adjective3, string adjective4, string properNoun1, string properNoun2, string properNoun3, string verb1, string verb2, string noun)
    {
      FinalStoryVariable myFinalStoryVariable = new FinalStoryVariable();
      myFinalStoryVariable.Adjective1 = adjective1;
      myFinalStoryVariable.Adjective2 = adjective2;
      myFinalStoryVariable.Adjective3 = adjective3;
      myFinalStoryVariable.Adjective4 = adjective4;
      myFinalStoryVariable.ProperNoun1 = properNoun1;
      myFinalStoryVariable.ProperNoun2 = properNoun2;
      myFinalStoryVariable.ProperNoun3 = properNoun3;
      myFinalStoryVariable.Verb1 = verb1;
      myFinalStoryVariable.Verb2 = verb2;
      myFinalStoryVariable.Noun = noun;
      return View(myFinalStoryVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    // [Route("/libs")]
    // public ActionResult Libs(string Adjective1, string Adjective2, string Adjective3, string Adjective4, string ProperNoun1, string ProperNoun2, string ProperNoun3, string Verb1, string Verb2, string Noun)
    // {
    //   FinalStoryVariable myFinalStoryVariable = new FinalStoryVariable();
    //   myFinalStoryVariable.Adjective1 = adjective1;
    //   myFinalStoryVariable.Adjective2 = adjective2;
    //   myFinalStoryVariable.Adjective3 = adjective3;
    //   myFinalStoryVariable.Adjective4 = adjective4;
    //   myFinalStoryVariable.ProperNoun1 = properNoun1;
    //   myFinalStoryVariable.ProperNoun2 = properNoun2;
    //   myFinalStoryVariable.ProperNoun3 = properNoun3;
    //   myFinalStoryVariable.Verb1 = verb1;
    //   myFinalStoryVariable.Verb2 = verb2;
    //   myFinalStoryVariable.Noun = noun;
    //   return View(myFinalStoryVariable);
    // }
  }
}