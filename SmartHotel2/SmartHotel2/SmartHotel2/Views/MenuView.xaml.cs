using SmartHotel2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartHotel2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuView : ContentPage
	{
		public MenuView ()
		{
			InitializeComponent ();

            // MenuViewModel.setMeNu();

            iMenu a = new iMenu();
            a.item = "Home View";
            a.rating = "rating.png";

            iMenu b = new iMenu();
            b.item = "My Room View";
            b.rating = "rating.png";


            iMenu c = new iMenu();
            c.item = "Book View";
            c.rating = "rating.png";

            List<iMenu> lst = new List<iMenu>();
            lst.Add(a);
            lst.Add(b);
            lst.Add(c);
            Menu.ItemsSource = lst;
           //  BindingContext = new MenuViewModel();
        }
        private void SelectItem(object sender, EventArgs e)
        {
            var item = (Xamarin.Forms.Label)sender;
            Label lb = item.FindByName<Label>("Menu");

            if (lb.Text.Trim() == "Home View")
            {
                if (Application.Current.MainPage is MainView mainView)
                {
                    if (mainView.Detail is NavigationPage navigationPage)
                    {
                        navigationPage.PushAsync(new HomeView());
                        mainView.IsPresented = false;
                    }
                }
            }
            //DisplayAlert("Cảnh báo", lb.Text,"X");
        }
        private void ListView_OnItemSelected(object sender, EventArgs e)
        {
            if (Menu.SelectedItem == null) return;


            Menu.SelectedItem = null;
        }
        private void onBookTap(object sender, EventArgs e)
        {
           if(Application.Current.MainPage is MainView mainView)
            {
               if( mainView.Detail is NavigationPage navigationPage)
                {
                    navigationPage.PushAsync(new BookingView());
                    mainView.IsPresented = false;
                }
            }
        }

        private void onMyRoomTap(object sender, EventArgs e)
        {
            if (Application.Current.MainPage is MainView mainView)
            {
                if (mainView.Detail is NavigationPage navigationPage)
                {
                    navigationPage.PushAsync(new MyRoom());
                    mainView.IsPresented = false;
                }
            }
        }
        private void onSuggesstionTap(object sender, EventArgs e)
        {
            if (Application.Current.MainPage is MainView mainView)
            {
                if (mainView.Detail is NavigationPage navigationPage)
                {
                    navigationPage.PushAsync(new SuggesstionView());
                    mainView.IsPresented = false;
                }
            }
        }

        private void onConciergeTap(object sender, EventArgs e)
        {
            if (Application.Current.MainPage is MainView mainView)
            {
                if (mainView.Detail is NavigationPage navigationPage)
                {
                    navigationPage.PushAsync(new ConciergeView());
                    mainView.IsPresented = false;
                }
            }
        }
       

        private void onLoginTap(object sender, EventArgs e)
        {
            Application.Current.MainPage = new SmartHotel2.Views.Login();
        }
    }
}