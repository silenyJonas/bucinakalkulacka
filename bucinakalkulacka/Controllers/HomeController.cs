using bucinakalkulacka.components;
using bucinakalkulacka.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace bucinakalkulacka.Controllers
{
    public class HomeController : BaseController
    {      
        public IActionResult Index(string value)
        {         
            try
            {
                if (string.IsNullOrEmpty(value))
                {
                    ViewBag.CelaCisla = false;
                    return View();
                }

                if (value == "backspace")
                {
                    content.PopValue();
                }
                else if (value == "=")
                {
                    content.AddDb(counter.GetValue(content.Value));
                    content.Value = counter.GetValue(content.Value);
                }
                else if (value == "squareRoot")
                {
                    content.Value = counter.Odmocnit(content.Value);
                }
                else if (value == "square")
                {
                    content.Value = counter.Mocnit(content.Value);
                }
                else if(value == "clear")
                {
                    content.Clear();
                }
                else if(value == "int")
                {
                    
                    content.CelaCislaSwap();
                }
                else
                {
                    content.AddValue(value);
                }
                
            }
            catch (Exception ex)
            {
                errorProvider.SendError(ex);
            }

            if (content.Value.Length > 20)
            {
                ViewBag.Value = ".." + content.Value.Substring(content.Value.Length - 20);
            }
            else
            {
                ViewBag.Value = content.Value;
            }

            ViewBag.Historie = content.Db;
            ViewBag.Counter = content.counter;            
            ViewBag.CelaCisla = ContentSingleton.GetInstance().CelaCisla;

            return View();
        }      
       
    }
}