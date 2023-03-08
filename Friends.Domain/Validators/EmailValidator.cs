
using Friends.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Friends.Domain.Validators
{
    public class EmailValidator : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if(value == null)
            {
                return new ValidationResult("All fields needs be complete");
            }
            var emailValue  = value as string;

            if (emailValue == null || emailValue.Length <3) 
            {
                return new ValidationResult("Fill in the field E-mail");
            }
            if(emailValue.Substring(emailValue.Length -3,3)!= ".it") {

                return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}
