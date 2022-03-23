using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using ContactUsForm.ViewModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Bizstream_Fullstack_Assignment.Controllers
{
    // Initializing the Controller
    public class HomeController : Controller
    {
        // Pulling data from form
        [HttpGet]
        public IActionResult Index(ContactViewModel vm)
        {
            return View();
        }

        // Button handler
        public DbSet<ContactViewModel> UserInfo{ get; set; }

        [HttpPost]
        public ActionResult UserSend(ContactViewModel vm)
        {
            return View();
        }
        // Email validation method
        /*              This is where things really went off the rails. I wrote this script
         *          at least four different ways using design patterns I am used to. All 
         *          the above code I wrote and re-wrote multiple times as well in an attempt
         *          to fix the issues with .net. I need to learn more .net, but I don't have 
         *          the time to do so before Bizstream hires someone else. So here is a plea: 
         *          Please give me a chance, I can do so much more with a functioning system 
         *          and will learn faster. I have the potential to do great things, and I would 
         *          truly appreciate the opportunity to do great things with your team. 
         *          Thank you for coming to my Ted talk.
         *          
        public bool IsValidEmail = false;
        string Email = vm.Email;
        string mainPath = AppDomain.CurrentDomain.BaseDirectory;
        string path = mainPath + "userInfo.txt";

        bool ValidateEmail(string Email)
        {
            var trimmedEmail = Email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(Email);
                if (addr.Address == trimmedEmail)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        // Data saving function, also implements email validation
        
        public SaveData(IsValidEmail){
            if (IsValidEmail() == true)
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    string first_name = vm.First_name;
                    string last_name = vm.Last_name;
                    string email = vm.Email;
                    string message = vm.Message;
                }
            }
            else
            {
                 Display "Email is not valid."
            }            
        }*/
    }
}
