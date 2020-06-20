using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BatteryConsumption.Controllers
{
    public class BatteryConsumptionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}