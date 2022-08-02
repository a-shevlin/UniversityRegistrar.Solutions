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
  public class DepartmentsController : Controller
  {
    private readonly UniversityRegistrarContext _db;

    public DepartmentsController(UniversityRegistrarContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Departments> model = _db.Departments.ToList();
      return View(model);
    }

    public ActionResult Create(int MajorId)
    {
      ViewBag.MajorId = MajorId;
      return View();
    }

    [HttpPost]
    public ActionResult Create(int MajorId, string name)
    {
      if (MajorId != 0)
      {
        _db.Departments.Add(new Departments() {MajorId = MajorId, Name = name});
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}