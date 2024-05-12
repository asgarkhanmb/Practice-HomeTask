using AspNet_MVC.Models;
using AspNet_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNet_MVC.Controllers

{
    public class HomeController : Controller
    {
        public  IActionResult Index()
        {
            string text = "Welcome";
            List<string> students = new List<string> { "Emirastan", "Fexriyye", "Elmir", "Ilqar", "Nurlan" };
            HomeVM model = new()
            {
                Text = text,
                Students = students,
                Users=GetAllUsers()
            };

            return View(model);
        }


        private List<User> GetAllUsers()
        {
            return new List<User>
            {
                new User
                {
                    Id = 1,
                    Age=100,
                },
                new User
                {
                    Id=2,
                    Age=50
                }

            };
        }
    }
}
