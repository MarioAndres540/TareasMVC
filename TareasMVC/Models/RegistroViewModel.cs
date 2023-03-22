using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace TareasMVC.Models
{
    public class RegistroViewModel
    {
        [Required(ErrorMessage ="El campo {0} es requerido")]
        [EmailAddress(ErrorMessage ="El campo de ser un correo electronico valido")]
        public string Email { get; set; }
        [Required(ErrorMessage ="El campo {0} es requerido")]
        [DataType(DataType.Password)]
        public int MyProperty { get; set; }
        public string Password { get; set; }
    }
}
