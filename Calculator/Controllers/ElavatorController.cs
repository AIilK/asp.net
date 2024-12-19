using Calculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    public class ElavatorController : Controller
    {
        public IActionResult home()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(User user)
        {
            user.haghebimepaye1 = user.taohedp  * (user.nerkh / 100) * user.zarfiat ;
            user.haghebimeh = user.haghebimepaye1 * (user.hazine / 100);
            user.haghebimepaye2 = ((user.mahadi * 8 / 12) + (user.mahharam * 4 / 12)) * (user.nerkh / 1000) * (user.tonaz / 75);
            user.haghebimepaye2 = user.haghebimepaye2 * (user.tedad / 100);
            user.haghebimepaye2 = user.haghebimepaye2 * (user.afzayesh1 / 100);
            user.haghebimepaye2 = user.haghebimepaye2 * (user.afzayesh2 / 100);
            user.haghebimepaye2 = user.haghebimepaye2 * (user.afzayesh3 / 100);
            user.haghebimepaye3 = user.maliha * (user.zaribe + 1) * (user.nerkh/100);
            user.haghebimeh = user.haghebimepaye1 + user.haghebimepaye2 + user.haghebimepaye3;
            user.haghebimeh = user.haghebimeh * (user.bedondar / 100);
            user.haghebimeh = user.haghebimeh * (user.tejari / 100);
            user.haghebimeh = user.haghebimeh * (user.bishaz / 100);
            user.haghebimeh = user.haghebimeh * (user.bedonray / 100);
            
            return View(user);
        }
        [HttpGet]
        public IActionResult nafarbar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult nafarbar(User user)
        {
            user.haghebimepaye1 = user.taohedp * (user.nerkh / 100) * user.zarfiat;
            user.haghebimepaye2 = ((user.mahadi * 8 / 12) + (user.mahharam * 4 / 12)) * (user.nerkh / 1000) * (user.tonaz / 75);
            user.haghebimeh = user.haghebimepaye1 + user.haghebimepaye2 + user.haghebimepaye3;
            user.haghebimeh = user.haghebimeh * (user.bedondar / 100);
            user.haghebimeh = user.haghebimeh * (user.tejari / 100);
            user.haghebimeh = user.haghebimeh * (user.bishaz / 100);
            user.haghebimeh = user.haghebimeh * (user.bedonray / 100);
            user.haghebimeh = user.haghebimepaye2 * (user.tedad / 100);
            user.haghebimeh = user.haghebimepaye2 * (user.afzayesh1 / 100);
            user.haghebimeh = user.haghebimepaye2 * (user.afzayesh2 / 100);
            user.haghebimeh = user.haghebimepaye2 * (user.afzayesh3 / 100);
            user.haghebimeh = user.haghebimepaye1 * (user.hazine / 100);

            return View(user);
        }

    }
}
