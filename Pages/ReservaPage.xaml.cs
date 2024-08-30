using System;
using Microsoft.Maui.Controls;

namespace CitasMedicas
{
    public partial class ReservaPage : ContentPage
    {
        public ReservaPage(string fecha, string especialidad, string medico)
        {
            InitializeComponent();

            
            FechaLabel.Text = $"Fecha: {fecha}";
            EspecialidadLabel.Text = $"Especialidad: {especialidad}";
            MedicoLabel.Text = $"M�dico: {medico}";
        }

        private async void OnAceptarClicked(object sender, EventArgs e)
        {
        
            await Navigation.PopToRootAsync();
        }

        private async void OnCancelarClicked(object sender, EventArgs e)
        { 
            // Navegar a la p�gina de Cancelar xd
            await Navigation.PushAsync(new CancelarPage());
        }
    }
}
