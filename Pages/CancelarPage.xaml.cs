using System;
using Microsoft.Maui.Controls;

namespace CitasMedicas
{
    public partial class CancelarPage : ContentPage
    {
        public CancelarPage()
        {
            InitializeComponent();
        }

        private async void OnAceptarClicked(object sender, EventArgs e)
        {
          
            await Navigation.PopToRootAsync();
        }
    }
}
