using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Inventory.Models;

namespace Inventory.Controllers;

public class HelloWordController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public string Welcome()
    {
        return "Этот метод Welcome";
    }
}
