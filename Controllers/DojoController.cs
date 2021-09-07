using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.Reflection;
using System.Linq;
namespace Arcade.Controllers
{
    public class Dojocontroller : Controller
    {

        [HttpGet]
        [Route("/dojodacahi")]
        public IActionResult Index()
        {
            int Happiness = HttpContext.Session.GetInt32("Happiness") ?? 20;
            int Fullness = HttpContext.Session.GetInt32("Fullness") ?? 20;
            int Energy = HttpContext.Session.GetInt32("Energy") ?? 50;
            int Meal = HttpContext.Session.GetInt32("Meal") ?? 3;
            string Message = HttpContext.Session.GetString("Message");
            // in your Controller
            ViewBag.Happiness = Happiness;
            ViewBag.Fullness = Fullness;
            ViewBag.Energy = Energy;
            ViewBag.Meal = Meal;
            ViewBag.Message = Message;
            return View("Index");
        }
        [HttpGet]
        [Route("/feed")]
        public IActionResult Feed()
        {
            int Fullness = HttpContext.Session.GetInt32("Fullness") ?? 20;
            int Meal = HttpContext.Session.GetInt32("Meal") ?? 3;
            string Message = HttpContext.Session.GetString("Message");
            Random rand = new Random();
            int success = rand.Next(1, 5);
            if (Meal > 0 && success > 1)
            {
                Random r = new Random();
                int food = r.Next(5, 11);
                Fullness += food;
                Meal--;
                HttpContext.Session.SetString("Message", $"Dojodachi ate the food! gained {food} Fullness");
                HttpContext.Session.SetInt32("Fullness", Fullness);
                HttpContext.Session.SetInt32("Meal", Meal);
            }
            else if (Meal > 0)
            {
                Meal--;
                HttpContext.Session.SetString("Message", $"Dojodachi didnt like the food...");
                HttpContext.Session.SetInt32("Fullness", Fullness);
                HttpContext.Session.SetInt32("Meal", Meal);
            }

            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("/play")]
        public IActionResult Play()
        {
            int Energy = HttpContext.Session.GetInt32("Energy") ?? 50;
            int Happiness = HttpContext.Session.GetInt32("Happiness") ?? 20;
            string Message = HttpContext.Session.GetString("Message");
            Random rand = new Random();
            int success = rand.Next(1, 5);
            if (Energy > 0 && success > 1)
            {
                Random r = new Random();
                int play = r.Next(5, 11);
                Happiness += play;
                Energy -= 5;
                HttpContext.Session.SetString("Message", $"Dojodachi enjoyed playtime! gained {play} Happiness");
                HttpContext.Session.SetInt32("Energy", Energy);
                HttpContext.Session.SetInt32("Happiness", Happiness);
            }
            else if (Energy > 0)
            {
                Energy -= 5;
                HttpContext.Session.SetString("Message", $"Oh no! Dojodachi tripped and fell :( ");
                HttpContext.Session.SetInt32("Energy", Energy);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("/sleep")]
        public IActionResult Sleep()
        {
            int Energy = HttpContext.Session.GetInt32("Energy") ?? 50;
            int Fullness = HttpContext.Session.GetInt32("Fullness") ?? 20;
            int Happiness = HttpContext.Session.GetInt32("Happiness") ?? 20;
            string Message = HttpContext.Session.GetString("Message");

            if (Fullness >= 5 && Happiness >= 5)
            {
                Happiness -= 5;
                Fullness -= 5;
                Energy += 15;
                HttpContext.Session.SetString("Message", $"Dojotachi took a nap Zzzzzzz...");
                HttpContext.Session.SetInt32("Energy", Energy);
                HttpContext.Session.SetInt32("Fullness", Fullness);
                HttpContext.Session.SetInt32("Happiness", Happiness);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("/work")]
        public IActionResult Work()
        {
            int Energy = HttpContext.Session.GetInt32("Energy") ?? 50;
            int Meal = HttpContext.Session.GetInt32("Meal") ?? 3;
            string Message = HttpContext.Session.GetString("Message");
            if (Energy >= 5)
            {
                Energy -= 5;
                Meal++;
                HttpContext.Session.SetString("Message", $"Dojotachi did some work! Gained 1 meal");
                HttpContext.Session.SetInt32("Energy", Energy);
                HttpContext.Session.SetInt32("Meal", Meal);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("/clear")]
        public IActionResult Clear()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }

}
