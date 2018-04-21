using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SmartHotel2.Droid.Services;
using SmartHotel2.Services;

[assembly: Dependency(typeof(EmailServiceDroid))]
namespace SmartHotel2.Droid.Services 
{
    public class EmailServiceDroid : IEmailService
    {
        public void Send(string email, string title, string content)
        {

        }
    }
}