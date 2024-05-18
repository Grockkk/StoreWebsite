using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using System.Threading.Tasks;

public class CustomAuthenticationStateProvider : AuthenticationStateProvider
{
    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        // Tutaj możesz implementować logikę pobierania informacji o zalogowanym użytkowniku
        // i tworzenia obiektu AuthenticationState na podstawie tych informacji

        var identity = new ClaimsIdentity(new[]
        {
            new Claim(ClaimTypes.Name, "UserName"),
            new Claim(ClaimTypes.Role, "UserRole")
        }, "test_authentication");

        var user = new ClaimsPrincipal(identity);

        return Task.FromResult(new AuthenticationState(user));
    }
}
