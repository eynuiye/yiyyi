using AvaloniaApplication3.Models;
using AvaloniaApplication3.Views;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication3.ViewModels
{
    public class LoginWindowViewModel : ViewModelBase
    {
        public string Login { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string _message = string.Empty; 
        public string Message
        {
            get => _message;
            set => this.RaiseAndSetIfChanged(ref _message, value);
        }
        public LoginWindow Owner { get; set; }
        public ReactiveCommand<Unit, Unit> AuthCommand { get; }
        public LoginWindowViewModel(LoginWindow _owner)
        {
            Owner = _owner;
            AuthCommand = ReactiveCommand.Create(Auth);
        }

        public void Auth()
        {
            Prakt11111Context dbContext = new Prakt11111Context();
            User? user = dbContext.Users.Where(u => u.Login == Login && u.Password == Password).FirstOrDefault();
            if (user == null)
            {
                Message = "Неправильный логин или пароль!";
            }

            else
            {
                Message = string.Empty;
                ServiceWindow serviceWindow = new ServiceWindow()
                {
                    DataContext = new ServiceWindowViewModel(user)
                };
                serviceWindow.Show();
                Owner.Close();
            }
        }
    }
}
