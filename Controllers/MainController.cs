using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RandomPasscode
{
    public class MainController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            // Creates the list for the random passcode. Includes entire alphabet and numbers AS STRINGS
            List<string> ranList = new List<string>();
            ranList.Add("A");
            ranList.Add("B");
            ranList.Add("C");
            ranList.Add("D");
            ranList.Add("E");
            ranList.Add("F");
            ranList.Add("G");
            ranList.Add("H");
            ranList.Add("I");
            ranList.Add("J");
            ranList.Add("K");
            ranList.Add("L");
            ranList.Add("M");
            ranList.Add("N");
            ranList.Add("O");
            ranList.Add("P");
            ranList.Add("Q");
            ranList.Add("R");
            ranList.Add("S");
            ranList.Add("T");
            ranList.Add("U");
            ranList.Add("V");
            ranList.Add("W");
            ranList.Add("X");
            ranList.Add("Y");
            ranList.Add("Z");
            ranList.Add("0");
            ranList.Add("1");
            ranList.Add("2");
            ranList.Add("3");
            ranList.Add("4");
            ranList.Add("5");
            ranList.Add("6");
            ranList.Add("7");
            ranList.Add("8");
            ranList.Add("9");
            
            // Base string for the model
            string passcode = "";
            
            // Random number generator to be run each time the get request is triggered.
            Random rand = new Random();
            
            // Counter for session -- may not need
            int? counter = HttpContext.Session.GetInt32("Counter");
            if (counter == null)
            {
                counter = 1;
            }
            else
            {
                counter++;
            }
            HttpContext.Session.SetInt32("Counter", Convert.ToInt32(counter));

            // Adds the Session to the Viewbag
            ViewBag.Counter = HttpContext.Session.GetInt32("Counter");

            // Creates the iterator

            int i = 0;
            
            while (i < 14)
            {
                int listNum = rand.Next(0,35);
                passcode = passcode + ranList[listNum];
                i++;
            }


            
            return View("Index", passcode);
        }
    }
}