using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _2021_MazlovaYelena.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Заполните это поле")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Заполните это поле")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
