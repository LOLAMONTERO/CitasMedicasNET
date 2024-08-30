using Microsoft.Maui.Controls;

namespace CitasMedicas.Pages
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void OnReservarCitasClicked(object sender, EventArgs e)
        {
           
            await Navigation.PushAsync(new ReservarPage());
        }

        private async void OnCerrarSesionClicked(object sender, EventArgs e)
        {
            
            await Navigation.PopToRootAsync();
        }
    }
}

