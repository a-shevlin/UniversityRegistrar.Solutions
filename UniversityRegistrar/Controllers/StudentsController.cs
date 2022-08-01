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
  public class StudentsController : Controller
  {
    private readonly UniversityRegistrarContext _db;

    public StudentsController(UniversityRegistrarContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Student> model = _db.Students.ToList();
      return View(model);
    }
  }
}