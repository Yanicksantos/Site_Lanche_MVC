using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Site_loja.Models;

namespace Site_loja.Controllers;

public class AparecerController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
