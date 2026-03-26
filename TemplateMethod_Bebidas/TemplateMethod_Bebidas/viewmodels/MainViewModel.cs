using System.ComponentModel;
using System.Windows.Input;
using TemplateMethod_Bebidas.Commands;

namespace TemplateMethod_Bebidas.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        // --- Propriedades bindadas na View ---

        private string _log;
        public string Log
        {
            get => _log;
            set { _log = value; OnPropertyChanged(nameof(Log)); }
        }

        // --- Comandos ---

        public ICommand PrepararCafeCommand { get; }
        public ICommand PrepararChaCommand  { get; }

        // --- Construtor ---

        public MainViewModel()
        {
            PrepararCafeCommand = new RelayCommand(PrepararCafe);
            PrepararChaCommand  = new RelayCommand(PrepararCha);
        }

        // --- Métodos privados ---

        private void PrepararCafe()
        {
            BebidaBase bebida = new Cafe();
            Log = "=== Preparando Café ===\n\n" + bebida.Preparar() + "\n✅ Café pronto!";
        }

        private void PrepararCha()
        {
            BebidaBase bebida = new Cha();
            Log = "=== Preparando Chá ===\n\n" + bebida.Preparar() + "\n✅ Chá pronto!";
        }

        // --- INotifyPropertyChanged ---

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string prop)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
