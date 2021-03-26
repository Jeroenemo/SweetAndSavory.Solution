using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using SweetAndSavory.Models;

namespace SweetAndSavory.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly SweetAndSavoryContext _db;

    public FlavorsController(SweetAndSavoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Flavor> model = _db.Flavors.ToList();
      return View(model);
    }

    [Authorize]
    public ActionResult Create()
    {
      return View();
    }
  }
}
