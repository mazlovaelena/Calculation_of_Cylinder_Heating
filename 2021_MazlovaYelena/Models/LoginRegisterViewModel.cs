using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace _2021_MazlovaYelena.Models
{
    public class LoginRegisterViewModel
    {
        [Required(ErrorMessage = "Заполните это поле")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Заполните это поле")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Заполните это поле")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Заполните это поле")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Заполните это поле")]
        [Compare ("Password", ErrorMessage = "Пароли не совпадают") ]
        [DataType(DataType.Password)]
        public string PasswordRetry { get; set; }

    }
}
