using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHotel2.ViewModels
{
    public static class MenuViewModel
    {
        public static List<iMenu> Menu { get; set; }
        public static void setMeNu()
        {
            iMenu a = new iMenu();
            a.item = "Menu 1";


            iMenu b = new iMenu();
            b.item = "Menu 2";



            iMenu c = new iMenu();
            c.item = "Menu 3";

            Menu.Add(a);
            Menu.Add(b);
            Menu.Add(c);
        }

        public static List<iMenu> getMeNu()
        {
            return Menu;
        }

    }
}
