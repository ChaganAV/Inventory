using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Inventory.Controllers
{
    public class HelloWordContrloller : Controller
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
}