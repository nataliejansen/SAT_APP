using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SNASA.UI.MVC.Models
{
    [Keyless]
    public class ContactViewModel
    {
        [Required (ErrorMessage ="*Name is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*Email is Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "*Subject is Required")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "*Message is Required")]
        [DataType (DataType.MultilineText)]
        public string Message { get; set; }
    }
}
