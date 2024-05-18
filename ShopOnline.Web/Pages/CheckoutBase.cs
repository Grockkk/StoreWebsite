using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;
using System.Linq;

namespace ShopOnline.Web.Pages
{
    public class CheckoutBase : ComponentBase
    {
        [Inject]
        public IJSRuntime Js { get; set; }

        protected IEnumerable<CartItemDto> ShoppingCartItems { get; set; }

        protected int TotalQty { get; set; }

        protected string PaymentDescription { get; set; }

        protected decimal PaymentAmount { get; set; }

        [Inject]
        public IUserService userService { get; set; }

        [Inject]
        public IShoppingCartService ShoppingCartService { get; set; }

        [Inject]
        public IManageCartItemsLocalStorageService ManageCartItemsLocalStorageService { get; set; }

        protected string DisplayButtons { get; set; } = "block";

        protected override async Task OnInitializedAsync()
        {
            try
            {
                ShoppingCartItems = await ManageCartItemsLocalStorageService.GetCollection();

                if (ShoppingCartItems != null && ShoppingCartItems.Any())
                {
                    Guid orderGuid = Guid.NewGuid();
                    var users = await userService.GetUsers();
                    var authenticatedUser = users.SingleOrDefault(p => p.Autentykacja);

                    if (authenticatedUser != null)
                    {
                        var userId = authenticatedUser.Id;
                        PaymentAmount = ShoppingCartItems.Sum(p => p.TotalPrice);
                        TotalQty = ShoppingCartItems.Sum(p => p.Qty);
                        PaymentDescription = $"O_{userId}_{orderGuid}";
                    }
                    else
                    {
                        // Użytkownik nie znaleziony
                        DisplayButtons = "none";
                    }
                }
                else
                {
                    DisplayButtons = "none";
                }
            }
            catch (Exception ex)
            {
                // Logowanie wyjątku
                Console.WriteLine($"Exception: {ex.Message}");
                DisplayButtons = "none";
            }
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            try
            {
                if (firstRender)
                {
                    await Js.InvokeVoidAsync("initPayPalButton");
                }
            }
            catch (Exception ex)
            {
                // Logowanie wyjątku
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
