using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2021_MazlovaYelena.Data
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }

    //public static class UserHelp
    //{
    //    public static List<User> Users = new List<User>
    //    {

    //            new User () {UserID = 1, Name = "Елена", Age=20, Email = "admin@mail.ru", Password ="123456"},
    //            new User () {UserID = 2, Name = "Ирина", Age=20, Email = "admin@gmail.com", Password ="654321"},
    //            new User () {UserID = 3, Name = "Алиса", Age=19, Email = "administr@yandex.ru", Password ="098765"},

    //    };

    //    public static void AddUser (User user)
    //    {
    //        Users.Add(user);
    //    }
    //}
}
