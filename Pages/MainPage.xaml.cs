using System;
using CitasMedicas.Pages;
using Microsoft.Maui.Controls;

namespace CitasMedicas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnIniciarSesionClicked(object sender, EventArgs e)
        {
            
            await Navigation.PushAsync(new MenuPage());
        }
    }
}
