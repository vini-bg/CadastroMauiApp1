using Microsoft.Extensions.DependencyInjection;

namespace CadastroMauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(new AppShell());

            window.Width = 560;
            window.Height = 840;

            return window;
        }
    }
}