using SmartHotel2.ViewModels;
using SmartHotel2.ViewModels.Base;
using SmartHotel2.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SmartHotel2.Services.Navigation
{
    public partial class NavigationService

    {

        private void Mappings()

        {

            Map<LoginViewModel, Login>();
            Map<MainViewModel, MainView>();
            Map<HomeViewModel, HomeView>();
        }



        private void Map<TViewModel, TView>()

            where TViewModel : ViewModelBase

            where TView : Page

        {

            _mappings.Add(typeof(TViewModel), typeof(TView));

        }

    }
}
