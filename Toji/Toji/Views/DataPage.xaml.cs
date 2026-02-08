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
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
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
    public sealed partial class DataPage : Page
    {
        private DataViewModel? viewModel;

        private PageCommand ToDetail { get; }

        public DataPage()
        {
            InitializeComponent();

            viewModel = App.Current.Services.GetService<DataViewModel>();
            SuperListView.SelectionChanged += SuperListView_SelectionChanged;

            ToDetail = new(Frame, typeof(DetailPage), false);
        }

        private void SuperListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (viewModel != null)
            {
                viewModel.RemoveCommand.NotifyCanExecuteChanged();
            }
            ToDetail.NotifyCanExecuteChanged();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (viewModel != null)
            {
                await viewModel.LoadAsync();
            }
        }
    }
}
