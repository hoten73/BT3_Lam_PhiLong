using SmartHotel2.Services.Navigation;
using SmartHotel2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SmartHotel2
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            ServiceLocator.Instance.Build();
            ServiceLocator.Instance.Resolve<INavigationService>().NavigateToAsync<LoginViewModel>();
           // MainPage = new NavigationPage(new SmartHotel2.Views.HomeView());
		}

		protected override void OnStart ()
		{   
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
