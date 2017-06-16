using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrashClickingMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Crash : ContentPage
    {
        //-------------------------------------------------------------
        public Crash()
        //-------------------------------------------------------------
        {
            InitializeComponent();
        }



        //-------------------------------------------------------------
        protected override void OnAppearing()
        //-------------------------------------------------------------
        {
            base.OnAppearing();

            Device.BeginInvokeOnMainThread(() => Animate(MyImage));
        }


        private bool bPageActive=true;

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            bPageActive = false;
        }

        bool _growbusy = false;
        private bool _animate_exit = false;
        //-------------------------------------------------------------
        private async Task Animate(Image myobject)
        //-------------------------------------------------------------
        {
            if (_growbusy) return;
#if DEBUG
            Debug.WriteLine("*** Animate started..");
#endif
            _growbusy = true;
            try
            {
                while (bPageActive)
                {
                    if (bPageActive) await myobject.ScaleTo(1.15, 500);
                    if (bPageActive) await myobject.ScaleTo(1.0, 500);
                    if (bPageActive) await myobject.ScaleTo(1.2, 500);
                    if (bPageActive) await myobject.ScaleTo(1.0, 500);
                }
            }
            catch
            {
#if DEBUG
                Debug.WriteLine("*** Animation STOPPED");
#endif
            }
#if DEBUG
            Debug.WriteLine("*** Animate exit.");
#endif
            _growbusy = false;

        }
    }
}