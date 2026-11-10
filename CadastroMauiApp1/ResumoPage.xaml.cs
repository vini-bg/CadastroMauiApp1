namespace CadastroMauiApp1;

public partial class ResumoPage : ContentPage
{
	public ResumoPage(Evento evento)
	{
		InitializeComponent();

        BindingContext = evento;
    }
}