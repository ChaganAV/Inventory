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

    public string Welcome(string name, int numTimes = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    }
}
