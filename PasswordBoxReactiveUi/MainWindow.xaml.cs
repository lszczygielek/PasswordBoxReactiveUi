using ReactiveUI;
using System.Reactive.Disposables;

namespace PasswordBoxReactiveUi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();

            this.ViewModel = new MainWindowViewModel();

            this.WhenActivated(d =>
            {
                this.WhenAnyValue(x => x.ViewModel).BindTo(this, x => x.DataContext).DisposeWith(d);
                this.BindCommand(ViewModel, vm => vm.ShowCommand, v => v.Button).DisposeWith(d);
            });
        }
    }
}
