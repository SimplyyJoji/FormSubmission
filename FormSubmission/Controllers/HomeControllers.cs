using Microsoft.AspNetCore.Mvc;
using YourNamespace.Models;


namespace YourNamespace.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("")]
    public IActionResult NewUser()
    {
      return View();
    }


  [HttpPost("user/create")]
public IActionResult Create(User user)
{
    if(ModelState.IsValid)
    {
        // do somethng!  maybe insert into db?  then we will redirect
        return View("Complete");
    }
    else
    {
        // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
        return View("NewUser");
    }
}



  }
}




// In HomeController
