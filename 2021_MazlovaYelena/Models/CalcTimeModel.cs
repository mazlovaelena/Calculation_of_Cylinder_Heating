using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _2021_MazlovaYelena.Models
{
    public class CalcTimeModel
    {
        [Required(ErrorMessage = "Заполните это поле")]
        [RegularExpression(@"\-?\d+(\.\d{0,})?", ErrorMessage = "Введите число")]
        public double r { get; set; }
        
        public double lamdaM { get; set; }
        
        public double cM { get; set; }
       
        public double roM { get; set; }
        [Required(ErrorMessage = "Заполните это поле")]
        [RegularExpression(@"\-?\d+(\.\d{0,})?", ErrorMessage = "Введите число")]
        public double alfa { get; set; }
        [Required(ErrorMessage = "Заполните это поле")]
        [RegularExpression(@"\-?\d+(\.\d{0,})?", ErrorMessage = "Введите число")]
        public double t_begin { get; set; }
        [Required(ErrorMessage = "Заполните это поле")]
        [RegularExpression(@"\-?\d+(\.\d{0,})?", ErrorMessage = "Введите число")]
        public double t_end { get; set; }
        [Required(ErrorMessage = "Заполните это поле")]
        [RegularExpression(@"\-?\d+(\.\d{0,})?", ErrorMessage = "Введите число")]
        public double t_p { get; set; }

        public string material { get; set; }
        public double T_DS { get; set; }
        public double Bi { get; set; }
        public double A { get; set; }
        public double TH { get; set; }
       
    }
}
