using System;
using System.Linq;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
using University.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace University.Controllers
{
  public class MajorsController : Controller
  {
    private readonly UniversityRegistrarContext _db;

    public MajorsController(UniversityRegistrarContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Major> model = _db.Majors.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Major major)
    {
      _db.Majors.Add(major);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisMajor = _db.Majors
        .Include(major => major.JoinDepartments)
        .FirstOrDefault(major => major.MajorId == id);
      return View(thisMajor);
    }
  }
}