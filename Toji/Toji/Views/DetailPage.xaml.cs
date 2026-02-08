using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Uzumasa.Actions;
using Uzumasa.Models;
using Uzumasa.ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Toji.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DetailPage : Page
    {
        private DatumnViewModel? viewModel;

        private PageCommand PageCommand { get; }

        private ObservableCollection<IBalanceAction> balanceActions =
            [
            new IncomeCash("IncomeCash"),
            new ChargeIcocaByCash("ChargeIcocaByCash"),
            new ChargeNanacoByCash("ChargeNanacoByCash"),
            new ChargeCoopByCash("ChargeCoopByCash"),
            new CashPayment("PayByCash"),
            new IcocaPayment("PayByIcoca"),
            new NanacoPayment("PayByNanaco"),
            new CoopPayment("PayByCoop"),
            new PointChargeIcoca("PointChargeIcoca"),
            new PointChargeNanaco("PointChargeNanaco"),
            new PointChargeCoop("PointChargeCoop")
            ];

        public DetailPage()
        {
            InitializeComponent();

            viewModel = App.Current.Services.GetService<DatumnViewModel>();

            PageCommand = new(Frame, typeof(DataPage));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (e.Parameter is Datumn datumn)
            {
                viewModel?.InitializeForExistingValue(datumn);
            }
        }
    }
}
