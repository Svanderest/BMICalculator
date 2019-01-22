using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BMICalculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int Height;
            int Weight;
            if (int.TryParse(txtHeight.Text, out Height) && int.TryParse(txtWeight.Text, out Weight))
                lblResult.Text = (new BmiCalculator(Height, Weight, lbxUnits.SelectedIndex == 0)).Result;
            else
                lblResult.Text = "Please enter whole number values for height and weight";
        }

        private void btnUnits_Click(object sender, RoutedEventArgs e)
        {
            stvMain.IsPaneOpen = true;
        }       

        private void lbxUnits_Tapped(object sender, TappedRoutedEventArgs e)
        {
            stvMain.IsPaneOpen = false;
            lblWeight.Text = lbxUnits.SelectedIndex == 0 ? "Weight (Kg)" : "Weight (lbs)";
            lblHeight.Text = lbxUnits.SelectedIndex == 0 ? "Height (m)" : "Height (in)";
        }
    }
}
