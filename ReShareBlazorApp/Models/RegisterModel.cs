using System.ComponentModel.DataAnnotations;

namespace ReShareBlazorApp.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Podaj Nazwę Użytkownika!")]
        [MinLength(8, ErrorMessage = "Nazwa Musi mieć min 8 znaków!")]
        [MaxLength(24, ErrorMessage = "Nazwa Musi mieć maksymalnie 24 znaki!")]
        public string Username { get; set; } = "";
        [Required(ErrorMessage = "Podaj Email!")]
        [EmailAddress(ErrorMessage = "Nieprawidłowy Email!")]
        public string Email { get; set; } = "";
        [Required(ErrorMessage = "Podaj Hasło!")]
        [MinLength(8, ErrorMessage = "Hasło Musi mieć min 8 znaków!")]
        public string Password { get; set; } = "";
        [Required(ErrorMessage = "Potwierdź Email!")]
        [Compare(nameof(Password), ErrorMessage = "Hasła muszą być identyczne")]
        public string ConfirmPassword { get; set; } = "";
        [Range(typeof(bool), "true", "true", ErrorMessage= "Zaakceptuj regulamin!")]
        public bool AcceptTerms { get; set; }
    }
}
