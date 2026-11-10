namespace CadastroMauiApp1

{

    public partial class MainPage : ContentPage
    {
        private Evento evento = new Evento();
        public MainPage()
        {
            InitializeComponent();

            BindingContext = evento;

            dt_inicio.Date = DateTime.Today;
            dt_termino.Date = DateTime.Today;
        }

        
        private async void btn_cadastrar_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (evento.DataInicio.Date < DateTime.Today)
                {
                    await DisplayAlertAsync("Atenção", "A data de início não pode ser anterior à data atual.", "OK");
                    return;
                }

                if (evento.DataTermino.Date < evento.DataInicio.Date)
                {
                    await DisplayAlertAsync("Atenção", "A data de término não pode ser anterior à data de início.", "OK");
                    return;
                }
                if (string.IsNullOrWhiteSpace(evento.Nome) || string.IsNullOrWhiteSpace(evento.Local))
                {
                    await DisplayAlertAsync("Atenção", "Por favor, preencha todos os campos obrigatórios.", "OK");
                    return;
                }
                if (evento.Custo <= 0 || evento.Participantes < 1)
                {
                    await DisplayAlertAsync("Atenção", "O custo não pode ser negativo e o número de participantes deve ser positivo.", "OK");
                    return;
                }
                await Navigation.PushAsync(new ResumoPage(evento));
            }
            catch (Exception ex)
            {
                await DisplayAlertAsync("Erro", ex.Message, "OK");
            }
        }
    }
}
