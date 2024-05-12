using HomeTask.Models;
using HomeTask.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HomeTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeVM model = new()
            {
                Students = GetStudentsOrderByAge(),
                Products= GetProducts()
            };

            return View(model);

        }

        private List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Name="Samsung",
                    Color="Black",
                    Price="1000"
                },
                new Product
                {
                    Name="Apple",
                    Color="White",
                    Price="2000"
                },
                new Product
                {
                    Name="Xiaomi",
                    Color="Red",
                    Price="800"
                }

            };
       
        }

        private List<Student> GetStudentsOrderByAge()
        {   
            List<Student> students= new List<Student>
            {

                        new Student
                        {
                        Name="Esgerxan",
                        Surname="Bayramov",
                        Age=18,
                        Email="esgerxan@gmail.com",
                        Phone="0515846411"
                        },

                        new Student
                        {
                        Name="Bahruz",
                        Surname="Eliyev",
                        Age=19,
                        Email="bahruz@gmail.com",
                        Phone="12345678"
                        },

                        new Student
                        {
                        Name="Reshad",
                        Surname="Agayev",
                        Age=27,
                        Email="reshad@gmail.com",
                        Phone="5151615648"
                        }

            };
            return students.OrderByDescending(m=>m.Age).ToList();
           
        }


    }

}
