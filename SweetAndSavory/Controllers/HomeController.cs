using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using SweetAndSavory.Models;

namespace SweetAndSavory.Controllers
{
  public class HomeController : Controller
  {
    private readonly SweetAndSavoryContext _db;
    public HomeController(SweetAndSavoryContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Tag> model = _db.Tags.ToList();
      return View(model);
    }
  }
}