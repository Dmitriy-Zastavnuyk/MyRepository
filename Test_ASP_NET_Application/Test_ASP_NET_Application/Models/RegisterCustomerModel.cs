using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test_ASP_NET_Application.Models
{
    public class RegisterCustomerModel
    {
        [Required(ErrorMessage = "Enter the name")]
        [StringLength(10, ErrorMessage = "Not more than 15 characters long")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter the surname")]
        [StringLength(15, ErrorMessage = "Not more than 15 characters long")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Enter the login")]
        [StringLength(15, ErrorMessage = "Not more than 15 characters long")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Enter the password")]
        [StringLength(20, MinimumLength = 7, ErrorMessage = "Enter a minimum of 7 characters")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmedPassword { get; set; }

        [Required(ErrorMessage = "Enter the email")]
        [RegularExpression(@"(?i)\b[A-z0-9._%-]+@[A-z0-9.-]+\.[A-z]{2,4}\b", ErrorMessage = "Wrong email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter the mobole number")]
        [RegularExpression(@"380[0-9]{9}\b", ErrorMessage = "Wrong mobile numder")]
        public string MobileNumber { get; set; }

        public bool RegistrationConsent { get; set; }

        public Sex CustomerSex { get; set; }

        public RegisterCustomerModel()
        {

        }
        public RegisterCustomerModel(string name, string surname, string login, string passw, string confpass, string email, Sex custsex, string mobnum, bool consent)
        {
            Name = name;
            SurName = surname;
            Password = passw;
            ConfirmedPassword = confpass;
            Login = login;
            Email = email;
            MobileNumber = mobnum;
            CustomerSex = custsex;
            RegistrationConsent = consent;
        }
    }

    public enum Sex : byte { Male, Female }

    



        
    


}