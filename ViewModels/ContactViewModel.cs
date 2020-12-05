using ElliotJDNaylor.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ElliotJDNaylor.ViewModels
{
    public class ContactViewModel
    {
        [Display(Name = "Your first name")]
        [Required(ErrorMessage = "Your first name is required")]
        public string FirstName { get; set; }

        [Display(Name = "Your last name")]
        [Required(ErrorMessage = "Your last name is required")]
        public string LastName { get; set; }

        [Display(Name = "Your email address")]
        [Required(ErrorMessage = "Your email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Display(Name = "Your contact number")]
        [Phone(ErrorMessage = "Invalid contact number")]
        public string ContactNumber { get; set; }

        [Display(Name = "Your message")]
        [Required(ErrorMessage = "Your message is required")]
        public string MessageContent { get; set; }

        //reCAPTCHA properties
        public string RecapthaSiteKey { get; set; }

        public string EmailContent
        {
            get
            {
                var sb = new StringBuilder();
                sb.AppendLine($"First name: {FirstName}");
                sb.AppendLine($"Last name: {LastName}");
                sb.AppendLine($"Email address: {Email}");

                if (!string.IsNullOrWhiteSpace(ContactNumber))
                    sb.AppendLine($"Contact number: {FirstName}");

                sb.AppendLine("Message:");
                sb.AppendLine(MessageContent);

                return sb.ToString();
            }
        }
    }
}