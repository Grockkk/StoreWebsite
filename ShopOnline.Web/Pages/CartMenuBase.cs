using Microsoft.AspNetCore.Components;
using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services;
using ShopOnline.Web.Services.Contracts;

namespace ShopOnline.Web.Pages
{
    public class CartMenuBase : ComponentBase
    {
        public UserDto User { get; set; }

        [Inject]
        public IUserService userService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var usersDto = await userService.GetUsers();


            if (usersDto != null)
            {
                User =  usersDto.SingleOrDefault(p => p.Autentykacja == true);
            }
            else
            {
                User = null;
            }
        }
    }

}
