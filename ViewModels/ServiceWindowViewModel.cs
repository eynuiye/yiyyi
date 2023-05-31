using AvaloniaApplication3.Models;
using Microsoft.EntityFrameworkCore;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication3.ViewModels
{
    public class ServiceWindowViewModel : ViewModelBase
    {
        private ObservableCollection<Service> _services;
        public ObservableCollection<Service> Services
        {
            get => _services;
            set => this.RaiseAndSetIfChanged(ref _services, value);
        }
        private User user { get; set; }
        public ServiceWindowViewModel()
        {
            Prakt11111Context dbContext = new Prakt11111Context();
            dbContext.Users.Load();
            dbContext.Services.Load();
            Services = dbContext.Services.Local.ToObservableCollection();
        }
        public ServiceWindowViewModel(User user) : this()
        {
            this.user = user;
        }
    }
}
