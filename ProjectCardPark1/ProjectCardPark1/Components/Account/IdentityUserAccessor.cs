using ProjectCardPark1.Data;
using Microsoft.AspNetCore.Identity;

namespace ProjectCardPark1.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<ProjectCardPark1User> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<ProjectCardPark1User> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
