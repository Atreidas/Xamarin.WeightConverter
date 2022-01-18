using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin.WeightConverter
{
    public partial class MainPage : ContentPage
    {
        private bool converting;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Entry_KilosChanged(object sender, TextChangedEventArgs e)
        {
            if (!converting)
            {
                converting = true;
                poundsText.Text = Converter.ToPounds(kilosText.Text);
            }
            else converting = false;
        }
        private void Entry_PoundsChanged(object sender, TextChangedEventArgs e)
        {
            if (!converting)
            {
                converting = true;
                kilosText.Text = Converter.ToKilos(poundsText.Text);
            }
            else converting = false;
        }

        private void weightText_Focused(object sender, FocusEventArgs e)
        {
            if (((Entry)sender).Text == "0")
            {
                ((Entry)sender).Text = "";
                converting = false;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
            //Process.GetCurrentProcess().CloseMainWindow();
        }
    }
}
