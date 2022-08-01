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
  public class CoursesController : Controller
  {
    private readonly UniversityRegistrarContext _db;

    public CoursesController(UniversityRegistrarContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Course> model = _db.Courses.ToList();
      return View(model);
    }
  }
}