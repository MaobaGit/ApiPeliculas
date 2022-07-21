using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.Models.DTOs
{
    public class UsuarioAuthLoginDto
    {
        [Required(ErrorMessage = "El usuario es obligatorio")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "El usuario es obligatorio")]
        public string Password { get; set; }
    }
}
