using bucinakalkulacka.components;
using bucinakalkulacka.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace bucinakalkulacka.Controllers
{
    public class HomeController : Controller
    {       
        public IActionResult Index(string value)
        {            
            if(string.IsNullOrEmpty(value))
            {
                return View();
            }

            if(value == "backspace")
            {
                ContentSingleton.GetInstance().Pop();
            }
            else if(value == "=")
            {
                ContentSingleton.GetInstance().Value = new Counter().GetValue(ContentSingleton.GetInstance().Value);
            }
            else if(value == "squareRoot")
            {
                ContentSingleton.GetInstance().Value = new Counter().Odmocnit(ContentSingleton.GetInstance().Value);
            }
            else if(value == "square")
            {
                ContentSingleton.GetInstance().Value = new Counter().Mocnit(ContentSingleton.GetInstance().Value);
            }
            else
            {
                ContentSingleton.GetInstance().Push(value);
            }

            if(ContentSingleton.GetInstance().Value.Length > 25)
            {
                ViewBag.Value = ".."+ ContentSingleton.GetInstance().Value.Substring(ContentSingleton.GetInstance().Value.Length-25);
            }
            else
            {
                ViewBag.Value = ContentSingleton.GetInstance().Value;
            }                    
            return View();
        }      
       
    }
}