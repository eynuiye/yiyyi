using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaApplication3.ViewModels;
using AvaloniaApplication3.Views;

namespace AvaloniaApplication3
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.DataContext = new LoginWindowViewModel(loginWindow);
                desktop.MainWindow = loginWindow;
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}