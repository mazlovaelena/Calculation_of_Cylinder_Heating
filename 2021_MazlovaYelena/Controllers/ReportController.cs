using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _2021_MazlovaYelena.Models;
using MathLibr_Cilindr;

namespace _2021_MazlovaYelena.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Report_temp(string material, CalcTempModel model)
        {
            var lib = new Formules();

            model.r = Formules.formules.r;
            model.material = Formules.formules.material;
            model.roM = Formules.formules.roM;
            model.lamdaM = Formules.formules.lamdaM;
            model.cM = Formules.formules.cM;
            model.alfa = Formules.formules.alfa;
            model.t = Formules.formules.t;
            model.Bi = lib.Bi();
            model.A = lib.A();
            model.Fo = lib.Fo();
            model.TDC = lib.TempDiff_Centr();
            model.TDM = lib.TempDiff_Mass();
            model.TDS = lib.TempDiff_Surface();


            return View(model);
           

        }

        public IActionResult Report_time(string material, CalcTimeModel calc)
        {
            var lib = new Formules { };
            
            calc.r = Formules.formules.r;
            calc.material = Formules.formules.material; 
            calc.roM = Formules.formules.roM;
            calc.cM = Formules.formules.cM;
            calc.lamdaM = Formules.formules.lamdaM ;
            calc.alfa = Formules.formules.alfa;
            calc.t_begin = Formules.formules.t_beg;
            calc.t_end = Formules.formules.t_end;
            calc.t_p = Formules.formules.t_p;
            calc.T_DS = lib.Temp_DiffSurface();
            calc.Bi = lib.Bi();
            calc.A = lib.A();
            calc.TH = lib.Time_heath();
            
            return View(calc);
        }
    }
}
