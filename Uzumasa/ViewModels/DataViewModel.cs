using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uzumasa.Contexts;
using Uzumasa.Models;

namespace Uzumasa.ViewModels
{
    public partial class DataViewModel : ObservableObject
    {
        private readonly UzumasaContext context;

        [ObservableProperty]
        private ObservableCollection<Datumn> data;
        [ObservableProperty]
        private double cashTotal = 0;
        [ObservableProperty]
        private double icocaTotal = 0;
        [ObservableProperty]
        private double nanacoTotal = 0;
        [ObservableProperty]
        private double coopTotal = 0;

        public DataViewModel()
        {
            context = new();
            Data = [];
        }

        [RelayCommand]
        public async Task LoadAsync()
        {
            if (await context.Database.EnsureCreatedAsync())
            {
                await context.AddAsync(new Datumn());
                await context.SaveChangesAsync();
            }
            Data.Clear();
            CashTotal = 0;
            IcocaTotal = 0;
            NanacoTotal = 0;
            CoopTotal = 0;

            List<Datumn> data = await context.Data.ToListAsync();
            data.Sort();

            foreach (Datumn datumn in data)
            {
                Data.Add(datumn);
                CashTotal += datumn.Cash;
                IcocaTotal += datumn.Icoca;
                NanacoTotal += datumn.Nanaco;
                CoopTotal += datumn.Coop;
            }
        }

        [RelayCommand(CanExecute = nameof(IsDatumnOK))]
        public async Task RemoveAsync(Datumn datumn)
        {
            context.Update(datumn);
            context.Remove(datumn);
            await context.SaveChangesAsync();
            await LoadAsync();
        }

        [RelayCommand]
        public async Task AddAsync()
        {
            await context.Database.EnsureCreatedAsync();
            var entry = await context.AddAsync(new Datumn());
            Data.Add(entry.Entity);
            await context.SaveChangesAsync();
        }

        public static bool IsDatumnOK(Datumn datumn)
        {
            return datumn != null;
        }
    }
}
