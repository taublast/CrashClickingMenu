using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CrashClickingMenu
{
    public class Root : MasterDetailPage
    {

        public Root()
        {

            var menu = new Menu();
            menu.Daddy = this;
            Master = menu;
            Master.Icon = "Icon-Small";
            
            Detail = new NavigationPage(new Crash());

        }

    }
}
