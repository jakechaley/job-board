using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
  public class JobsController : Controller
  {
    [HttpGet("/jobs")]
    public ActionResult Index()
    {
      List<Job> allJobs = Job.GetAll();
      return View(allJobs);
    }

    [Route("/jobs/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/jobs")]
    public ActionResult Create(string title, string description, string contactName, string contactEmail, string contactPhoneNumber)
    {
      Job myJob = new Job(title, description, contactName, contactEmail, contactPhoneNumber);
      return RedirectToAction("Index");
    }

    [HttpGet("/jobs/{id}")]
    public ActionResult Show(int id)
    {
      Job foundJob = Job.Find(id);
      return View(foundJob);
    }
  }
}