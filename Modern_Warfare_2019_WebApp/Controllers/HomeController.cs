using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Modern_Warfare_2019_WebApp.Models;
using Newtonsoft.Json;

namespace Modern_Warfare_2019_WebApp.Controllers
{
    public class HomeController : Controller
    {
        //create a file to store the users
        private static string UsersFile = "Users.txt";
        public List<User> users = new List<User>();
        public User currentUser;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string userJson = HttpContext.Session.GetString("UserListSession");
            if (userJson != null)
            {
                users = JsonConvert.DeserializeObject<List<User>>(userJson);
                return View(users);
            }

            return View();
            
        }

        
        public IActionResult RegisterUser()
        {
            return View();
        }

        public IActionResult UserLogin()
        {
            return View();
        }

        public IActionResult LoginValidation(string Email, string Password)
        {
            //populate the users lists
            PopulateFromSession();

            //check to see if current user session

            //determine if the email and password cobination exist in the list
            foreach (User user in users)
            {
                if (user.Email == Email && user.Password == Password)
                {
                    currentUser = user;
                    //store this user in the current session of the proram
                    PopulateCurrentSession();
                    
                    HttpContext.Session.SetString("CurrentSession",
                        JsonConvert.SerializeObject(currentUser));

                    //take user to valid Login page
                    return View("LoginValidation", currentUser);
                }
            }

            //the user was not found. Take the user back to the Login Page
            return View("UserLogin");
        }

        public IActionResult SaveUser(User newUser)
        {
            PopulateFromSession();
            users.Add(newUser);
            WriteUsers();
            HttpContext.Session.SetString("UserListSession",
                JsonConvert.SerializeObject(users));

            return RedirectToAction("Index");

        }

        public void PopulateFromSession()
        {
            string userListJson = HttpContext.Session.GetString("UserListSession");

            if (userListJson != null)
            {
                users = JsonConvert.DeserializeObject<List<User>>(userListJson);
            }

        }

        public void PopulateCurrentSession()
        {
            string userJson = HttpContext.Session.GetString("CurrentSession");

            if (userJson != null)
            {
                currentUser = JsonConvert.DeserializeObject<User>(userJson);
            }

        }

        public IActionResult UserDetails()
        {
            PopulateCurrentSession();
            return View(currentUser);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public void WriteUsers()
        {
            StreamWriter writer = new StreamWriter(UsersFile);
            foreach (User user in users)
            {
                writer.WriteLine($"{user.Name}|{user.Email}|{user.Password}");
            }
            writer.Close();
        }

        public IActionResult LogOut()
        {
            //clear the current user session
            HttpContext.Session.Clear();

            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
