using Friends.Domain.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friends.Domain.ViewModels
{
    public class MessageModel
    {
        [Required(ErrorMessage = "Please, enter with the Name")]
        [MaxLength(50, ErrorMessage = "The name seems to have more characters than allowed. Max length: 1000 characters\"")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please, enter with the E-mail")]
        [RegularExpression("\\S*@\\S*\\.\\S*", ErrorMessage = "Pleace check your e-mail.")]
        [MaxLength(50, ErrorMessage = "The e-mail seems to have more characters than allowed. Max length: 1000 characters\"")]
        [EmailValidator(ErrorMessage ="The e-mail isnt italian")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please, enter with the Message")]
        [MaxLength(1000, ErrorMessage = "Your message seems to have more characters than allowed. Max length: 1000 characters")]
        [MinLength(10, ErrorMessage = "Please, your message needs to be bigger then 10 characters")]

        public string? Text { get; set; }
    }
}
