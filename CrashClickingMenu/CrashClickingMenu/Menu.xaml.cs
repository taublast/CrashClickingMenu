using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrashClickingMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {

        public Root Daddy { get; set; } = null;
        public Menu()
        {
            InitializeComponent();
        }
        //-------------------------------------------------------------
        private void MenuClicked(object sender, EventArgs e)
        //-------------------------------------------------------------
        {
            if (Daddy!=null) Daddy.IsPresented = false;
        }
    }
}