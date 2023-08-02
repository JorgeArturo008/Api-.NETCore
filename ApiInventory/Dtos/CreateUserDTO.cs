using System.ComponentModel.DataAnnotations;

namespace ApiInventory.Dtos
{
    public class CreateUserDTO
    {

        [Required (ErrorMessage = "Debe de tener un Nombre de Usuario") ]
        public string UserName { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = ("Debe Contener una @ y unA terminacion Valida"))]
        public string Email { get; set; }

        [RegularExpression(@"^.{8,}$", ErrorMessage = "La contraseña debe tener minimo 8 dijitos")]
        public string Password { get; set; }
    }

}
