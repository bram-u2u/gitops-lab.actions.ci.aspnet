﻿using BoardGamesInventory.Models;
using Microsoft.AspNetCore.Mvc;

namespace BoardGamesInventory.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger) 
      => this._logger = logger;

    public IActionResult Index() 
      => View();

    public IActionResult Privacy() 
      => View();

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() 
      => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
  }
}