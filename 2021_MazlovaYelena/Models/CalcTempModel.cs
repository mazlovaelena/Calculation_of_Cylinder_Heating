using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _2021_MazlovaYelena.Models
{
    public class CalcTempModel
    {
        [Required(ErrorMessage = "Заполните это поле")]
        [RegularExpression(@"\-?\d+(\.\d{0,})?", ErrorMessage ="Введите число")]
        public double r { get; set; }
       
        public double lamdaM { get; set; }
       
        public double cM { get; set; }
       
        public double roM { get; set; }
        [Required(ErrorMessage = "Заполните это поле")]
        [RegularExpression(@"\-?\d+(\.\d{0,})?", ErrorMessage = "Введите число")]
        public double alfa { get; set; }
        [Required(ErrorMessage = "Заполните это поле")]
        [RegularExpression(@"\-?\d+(\.\d{0,})?", ErrorMessage = "Введите число")]
        public double t { get; set; }
        public string material { get; set; }

        public double Bi { get; set; }
        public double A { get; set; }
        public double Fo { get; set; }

        public double TDS { get; set; }
        public double TDC { get; set; }
        public double TDM { get; set; }
    }
}
