 using _2021_MazlovaYelena.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MathLibr_Cilindr;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _2021_MazlovaYelena.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Temp_heath(string material)
        {
            
            var VM = new CalcTempModel
            {
                material = material,
                r = Formules.GetData().r,
                alfa = Formules.GetData().alfa,
                t = Formules.GetData().t,
            };
            switch (material)
            {
                case "Cталь":
                    VM.lamdaM = 42;
                    VM.cM = 712;
                    VM.roM = 7860;
                    break;
                case "Чугун":
                    VM.lamdaM = 62.8;
                    VM.cM = 541;
                    VM.roM = 7000;
                    break;
                case "Олово":
                    VM.lamdaM = 66.11;
                    VM.cM = 234;
                    VM.roM = 7300;
                    break;
                case "Свинец":
                    VM.lamdaM = 33.4;
                    VM.cM = 140;
                    VM.roM = 11300;
                    break;
                default:
                    VM.lamdaM = Formules.GetData().lamdaM;
                    VM.cM = Formules.GetData().cM;
                    VM.roM = Formules.GetData().roM;
                    break;
            }
            if (!ModelState.IsValid)
            {
                return View();
            }
            return View(VM);
        }


        [HttpPost]
        public IActionResult Result_temp(CalcTempModel model)
        {
            var lib = new Formules ();
            Formules.formules.r = model.r;
            Formules.formules.roM = model.roM;
            Formules.formules.cM = model.cM;
            Formules.formules.lamdaM = model.lamdaM;
            Formules.formules.alfa = model.alfa;
            Formules.formules.t = model.t;
            Formules.formules.material = model.material;
            model.Bi = lib.Bi();
            model.A = lib.A();
            model.Fo = lib.Fo();
            model.TDC = lib.TempDiff_Centr();
            model.TDM = lib.TempDiff_Mass();
            model.TDS = lib.TempDiff_Surface();
            
            return View(model);
        }


        public IActionResult Result_temp()
        {
         
            return View();
        }

       

        public IActionResult Time_heath(string material)
        {
           
            var VM = new CalcTimeModel
            {
                material = material,
                r = Formules.GetData().r,
                alfa = Formules.GetData().alfa,
                t_begin = Formules.GetData().t_beg,
                t_end = Formules.GetData().t_end,
                t_p = Formules.GetData().t_p
            };
            switch (material)
            {
               case "Cталь":
                    VM.lamdaM = 42;
                    VM.cM = 712;
                    VM.roM = 7860;
                    break;
                case "Чугун":
                    VM.lamdaM = 62.8;
                    VM.cM = 541;
                    VM.roM = 7000;
                    break;
                case "Олово":
                    VM.lamdaM = 66.11;
                    VM.cM = 234;
                    VM.roM = 7300;
                    break;
                case "Свинец":
                    VM.lamdaM = 33.4;
                    VM.cM = 140;
                    VM.roM = 11300;
                    break;
                default:
                    VM.lamdaM = Formules.GetData().lamdaM;
                    VM.cM = Formules.GetData().cM;
                    VM.roM = Formules.GetData().roM;
                    break;
            }
            if (!ModelState.IsValid)
            {
                return View(VM);
            }

            return View(VM);
        }

        [HttpPost]
        public IActionResult Result_time(CalcTimeModel calc)
        {
            var lib = new Formules ();
            Formules.formules.r = calc.r;
            Formules.formules.roM = calc.roM;
            Formules.formules.cM = calc.cM;
            Formules.formules.lamdaM = calc.lamdaM;
            Formules.formules.alfa = calc.alfa;
            Formules.formules.t_beg = calc.t_begin;
            Formules.formules.t_end = calc.t_end;
            Formules.formules.t_p = calc.t_p;
            Formules.formules.material = calc.material;
            calc.T_DS = lib.Temp_DiffSurface();
            calc.Bi = lib.Bi();
            calc.A = lib.A();
            calc.TH = lib.Time_heath();
           
            return View(calc);
        }

        public IActionResult Result_time()
        {
            return View();
        }
         
        
        public IActionResult Report_temp()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int code)
        {
            if (code == 404)
            {
                return View("Error");
            }

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
       
    }
}
