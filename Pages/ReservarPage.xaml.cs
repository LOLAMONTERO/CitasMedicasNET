using System;
using Microsoft.Maui.Controls;

namespace CitasMedicas
{
    public partial class ReservarPage : ContentPage
    {
        public ReservarPage()
        {
            InitializeComponent();
        }

        private async void OnReservarClicked(object sender, EventArgs e)
        {
            // Obtener los datos ingresados
            string fecha = FechaPicker.Date.ToString("dd/MM/yyyy");
            string especialidad = EspecialidadPicker.SelectedItem?.ToString() ?? "No seleccionada";
            string medico = MedicoPicker.SelectedItem?.ToString() ?? "No seleccionado";

            // Validar los datos *necesario para l fech
            if (string.IsNullOrWhiteSpace(fecha) || especialidad == "No seleccionada" || medico == "No seleccionado")
            {
                await DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
                return;
            }

            // Navegar a la página de Reserva con los datos, esto me mato
            await Navigation.PushAsync(new ReservaPage(fecha, especialidad, medico));
        }
    }
}
