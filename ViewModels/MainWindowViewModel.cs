using AvaloniaApplication3.Models;
using Microsoft.EntityFrameworkCore;
using ReactiveUI;
using System.Collections.ObjectModel;
using Tmds.DBus;

namespace AvaloniaApplication3.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<Order> _orders;
        public ObservableCollection<Order> Orders
        {
            get => _orders;
            set => this.RaiseAndSetIfChanged(ref _orders, value);
        }
        private ObservableCollection<Service> _services;
        public ObservableCollection<Service> Services
        {
            get => _services;
            set => this.RaiseAndSetIfChanged(ref _services, value);
        }
        private User user { get; set; }
        public MainWindowViewModel() 
        {
            Prakt11111Context dbContext = new Prakt11111Context();
            dbContext.Users.Load();
            dbContext.Orders.Load();
            dbContext.Services.Load();
        }
        public MainWindowViewModel(User user) : this()
        {
            this.user = user;
        }
    }
}