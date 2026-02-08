using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uzumasa.Actions;
using Uzumasa.Contexts;
using Uzumasa.Models;

namespace Uzumasa.ViewModels
{
    public partial class DatumnViewModel : ObservableObject
    {
        private readonly UzumasaContext context;
        private Datumn datumn;


        private DateTime dateTime;

        public DateTimeOffset Date
        {
            get
            {
                return dateTime.Date;
            }

            set
            {
                DateTimeOffset d = dateTime.Date;
                TimeSpan t = dateTime.TimeOfDay;
                SetProperty(ref d, value);
                dateTime = d.Date.Add(t);
                datumn.DateTime = dateTime;
            }
        }
        public TimeSpan Time
        {
            get
            {
                 return dateTime.TimeOfDay; 
            }

            set
            {
                DateTime d = dateTime.Date;
                TimeSpan t = dateTime.TimeOfDay;
                SetProperty(ref t, value);
                dateTime = d.Date.Add(t);
                datumn.DateTime = dateTime;
            }
        }


        private string item;

        public string Item
        {
            get { return item; }
            set
            {
                SetProperty(ref item, value);
                datumn.Item = value;
            }
        }

        private double balance = 0;
        private IBalanceAction action;

        public IBalanceAction Action
        {
            get
            {
                return action;
            }
            
            set
            {
                SetProperty(ref action, value);
                value.Execute(ref datumn, Balance);
            }
        }

        public double Balance
        {
            get { return balance; }

            set
            {
                SetProperty(ref balance, value);
                Action.Execute(ref datumn, value);
            }
        }

        public DatumnViewModel()
        {
            context = new();
            datumn = new();
            dateTime = datumn.DateTime;
        }

        public void InitializeForExistingValue(Datumn value)
        {
            datumn = value;
        }

        [RelayCommand]
        public async Task SaveAsync()
        {
            context.Update(datumn);
            await context.SaveChangesAsync();
        }
    }
}
