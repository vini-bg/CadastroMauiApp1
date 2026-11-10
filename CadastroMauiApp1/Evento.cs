using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CadastroMauiApp1

{
    public class Evento : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public string? Nome { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataTermino { get; set; }

        private int participantes = 1;

        public int Participantes
        {
            get { return participantes; }
            set
            {
                participantes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Participantes)));
            }
        }

        public string? Local { get; set; }

        public decimal Custo { get; set; }

        public int Duracao
        {
            get
            {
                TimeSpan duracao = DataTermino - DataInicio;
                return duracao.Days;
            }
        }

        public decimal CustoTotal
        {
            get
            {
                return Custo * Participantes;
            }
        }
    }
}
