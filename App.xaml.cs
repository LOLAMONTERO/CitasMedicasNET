using Microsoft.Maui.Controls;

namespace CitasMedicas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Configuración de la página de navegación
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
