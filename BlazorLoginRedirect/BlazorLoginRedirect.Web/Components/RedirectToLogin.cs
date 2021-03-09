using Microsoft.AspNetCore.Components;
using System;

namespace BlazorLoginRedirect.Web.Components
{
    public class RedirectToLogin : ComponentBase
    {
        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        protected override void OnInitialized()
        {
            try
            {
                NavigationManager.NavigateTo("Identity/Account/Login", true);
            }
            catch(Exception)
            {

            }
        }
    }
}