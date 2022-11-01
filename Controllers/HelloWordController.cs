using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Inventory.Models;

namespace Inventory.Controllers;

public class HelloWordController : Controller
{
    public string Index()
    {
        return "Этот метод по умолчанию";
    }

    public string Welcome()
    {
        return "Этот метод Welcome";
    }
}
