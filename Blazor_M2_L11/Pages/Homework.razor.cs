using Microsoft.AspNetCore.Components;

namespace Blazor_M2_L11.Pages
{
    public partial class Homework
    {
        [Parameter]
        public string? Header { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public void GoToHome()
        {
            NavigationManager.NavigateTo("/");
        }
    }
}
