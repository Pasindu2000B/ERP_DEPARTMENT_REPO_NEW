using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using System.Security.Claims;
using System.Threading.Tasks;

public class CustomAuthenticationStateProvider : AuthenticationStateProvider
{
    private readonly IJSRuntime _jsRuntime;
    private ClaimsPrincipal _anonymous = new ClaimsPrincipal(new ClaimsIdentity());
    private ClaimsPrincipal _user;
    private bool _isInitialized = false;

    public CustomAuthenticationStateProvider(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
        _user = _anonymous;
    }

    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        if (!_isInitialized)
        {
            return Task.FromResult(new AuthenticationState(_anonymous));
        }
        return Task.FromResult(new AuthenticationState(_user));
    }

    public async Task InitializeAsync()
    {
        var token = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "authToken");

        if (!string.IsNullOrEmpty(token))
        {
            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, "coordinator@example.com"),
                new Claim("http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Coordinator")
            }, "jwt");

            _user = new ClaimsPrincipal(identity);
        }
        else
        {
            _user = _anonymous;
        }

        _isInitialized = true;
        NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(_user)));
    }

    public void MarkUserAsAuthenticated(string token)
    {
        var identity = new ClaimsIdentity(new[]
        {
            new Claim(ClaimTypes.Name, "coordinator@example.com"),
            new Claim("http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Coordinator"),
            
        }, "jwt");

        _user = new ClaimsPrincipal(identity);
        NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(_user)));
    }

    public void MarkUserAsLoggedOut()
    {
        _user = _anonymous;
        NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(_user)));
    }
}
