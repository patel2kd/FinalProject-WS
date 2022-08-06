using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Login_1.Models;

namespace Login_1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public MemberManagerContext data { get; set; }

    //public HomeController(MemberManagerContext ctx) => data = ctx;

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult member1()
    {
        return View();
    }
    public IActionResult member2()
    {
        return View();
    }
    public IActionResult member3()
    {
        return View();
    }
    public IActionResult aboutus()
    {
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpGet]
    public ViewResult Add() => View(new Member());

    [HttpPost]
    public IActionResult Add(Member temp)
    {
        if (ModelState.IsValid)
        {
            data.Members.Add(temp);
            data.SaveChanges();

            return RedirectToAction("Index");
        }
        else
        {
            ModelState.AddModelError("", "Please correct all errors.");
            return View(temp);
        }
    }
}