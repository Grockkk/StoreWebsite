using System.ComponentModel.DataAnnotations;

namespace ShopOnline.Web.Pages.Account
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings =false, ErrorMessage ="Podaj poprane dane")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Podaj poprane dane")]
        public string Password { get; set; }
    }
}
