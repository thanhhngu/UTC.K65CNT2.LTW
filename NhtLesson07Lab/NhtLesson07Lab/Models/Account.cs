using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace NhtLesson07Lab.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [
            Display(Name = "Full Name"),
            Required(ErrorMessage = "Full Name is required"),
            MinLength(3, ErrorMessage = "Full Name must be at least 3 characters long"),
            MaxLength(50, ErrorMessage = "Full Name cannot exceed 50 characters")
        ]
        public string FullName { get; set; }
        
        [
            Display(Name = "Email"),
            Required(ErrorMessage = "Email is required"),
            EmailAddress(ErrorMessage = "Invalid email format")
        ]
        public string Email { get; set; }
        [
            Display(Name = "Phone"),
            Required(ErrorMessage = "Phone is required"),
            Remote(action: "IsPhoneAvailable", controller: "Account"),
            Phone(ErrorMessage = "Invalid phone number format")
        ]
        public string Phone { get; set; }
        [
            Display(Name = "Address"),
            Required(ErrorMessage = "Address is required"),
            MinLength(5, ErrorMessage = "Address must be at least 5 characters long"),
            MaxLength(100, ErrorMessage = "Address cannot exceed 100 characters")
        ]
        public string Address { get; set; }

        [
            Display(Name = "Avatar")
        ]
        public string Avatar { get; set; }
        [
            Display(Name = "Birthday"),
            Required(ErrorMessage = "Birthday is required"),
            DataType(DataType.Date)
        ]
        public DateTime Birthday { get; set; }
        [
            Display(Name = "Gender")
        ]
        public string Gender { get; set; }
        [
            Display(Name = "Password"),
            Required(ErrorMessage = "Password is required"),
            MinLength(6, ErrorMessage = "Password must be at least 6 characters long")
        ]
        public string Password { get; set; }
        [
            Display(Name = "Facebook"),
            Required(ErrorMessage = "Facebook is required"),
            Url(ErrorMessage = "Invalid URL format for Facebook")
        ]
        public string Facebook { get; set; }
    }
}
