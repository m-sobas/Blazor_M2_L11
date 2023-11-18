using Microsoft.AspNetCore.Components;

namespace Blazor_M2_L11.Pages
{
    public partial class Home
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public string? Parametr { get; set; }

        public void GoToHomework()
        {
            NavigationManager.NavigateTo("/homework/" + Parametr);
        }
    }
}
