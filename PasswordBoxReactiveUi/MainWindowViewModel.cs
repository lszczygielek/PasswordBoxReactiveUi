using ReactiveUI;
using System.Reactive;
using System.Windows;

namespace PasswordBoxReactiveUi
{
    public class MainWindowViewModel : ReactiveObject
    {
        private string password;

        public ReactiveCommand<Unit, Unit> ShowCommand { get; }

        public string Password
        {
            get => password;
            set => this.RaiseAndSetIfChanged(ref password, value);
        }

        public MainWindowViewModel()
        {
            this.ShowCommand = ReactiveCommand.Create(() =>
            {
                _ = MessageBox.Show(this.Password);
                return;
            });
        }
    }
}
