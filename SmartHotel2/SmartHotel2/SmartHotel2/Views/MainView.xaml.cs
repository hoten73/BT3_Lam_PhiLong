using SmartHotel2.Services;
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
	public partial class MainView : MasterDetailPage
    {
		public MainView ()
		{
			InitializeComponent ();
             NavigationPage.SetHasNavigationBar(this, false);
            var service = DependencyService.Get<IEmailService>();
            service.Send("ac","c","aa");
        }
        private void Back_Clicked(object sender, EventArgs e)
        {

            Navigation.PopAsync();
               
        }
    }
}