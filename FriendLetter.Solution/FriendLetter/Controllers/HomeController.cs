using FriendLetter.Models;

using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
        
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }



      ///rotue path every project must have 
    [Route("/")]
    public ActionResult Letter() {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Lina";
      myLetterVariable.Sender = "Jasmine";
      return View(myLetterVariable);
       }



      [Route("/postcard")]
      public ActionResult Postcard(string recipient, string sender, string items, string location)
      {
        LetterVariable myLetterVariable = new LetterVariable();
        myLetterVariable.Recipient = recipient;
        myLetterVariable.Sender = sender;
        myLetterVariable.Items = items;
        myLetterVariable.Location = location;
        return View(myLetterVariable);
      }

     [Route("/form")]
    public ActionResult Form() { return View(); }
    
  }
}
////MVC

///Models-- model is data used by a program
/// View-- a view is means of displaying objects within an aplication
/// Controller-- a controller updates both models and views. it accepts input and performs the corresponding update.

/// Razor-- Razor is a markup syntax that lets you embed server-based code


/// what are the steps for setting up an ASP.NET MVC project?



///How can we gather form data in an MVC route? What needs to be in place to make this possible? --- setting up the routes as we did above
