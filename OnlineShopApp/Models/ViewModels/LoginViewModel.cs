using System.ComponentModel.DataAnnotations;

namespace OnlineShopApp.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста, введите логин")]
        public string? Login {  get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста, введите пароль")]
        public string? Password {  get; set; }
    }
}
