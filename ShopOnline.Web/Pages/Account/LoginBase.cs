using Microsoft.AspNetCore.Components;
using ShopOnline.Models.Dtos;

namespace ShopOnline.Web.Pages.Account
{
    public class LoginBase:ComponentBase
    {
        public UserDto User { get; set; }

    }
}
