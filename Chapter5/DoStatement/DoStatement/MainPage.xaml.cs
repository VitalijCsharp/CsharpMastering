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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DoStatement
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

        //private void showStepsClick(object sender, RoutedEventArgs e)
        //{
        //    steps.Text = "";
        //    int tmp = System.Int32.Parse(number.Text);
        //    int counter = 0;
        //    int div = 0;
        //    int residue = 0;
        //    string result = "";
        //    do
        //    {
        //        counter++;
        //        div = tmp / 8;
        //        residue = tmp % 8;
        //        steps.Text += $"{counter}. {tmp} / 8  = {div}; {tmp} % 8 = {residue} \n";
        //        result = residue.ToString() + result;
        //        tmp = div;
        //    } while (div > 0);
        //    steps.Text += $"result : {result}";

        //}

        private void showStepsClick(object sender, RoutedEventArgs e)
        {
            int amount = System.Int32.Parse(number.Text);
            steps.Text = "";
            string current = "";
           
            do
            {
                int nextDigit = amount % 8;
                amount /= 8;
                int codChar = '0' + nextDigit;
                steps.Text += codChar.ToString() + "\n";
                char dig = Convert.ToChar(codChar);
                current = dig + current;
                steps.Text += current + "\n";

            } while (amount != 0);
           

        }
    }
}
