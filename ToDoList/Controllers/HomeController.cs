using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
      private readonly ToDoListContext _db;

      public HomeController(ToDoListContext db)
      {
        _db = db;
      }
      
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}