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

namespace Indexers
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private PhoneBook phoneBook = new PhoneBook();

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void findByNameClick(object sender, RoutedEventArgs e)
        {
            //Name _name = new Name(name.Text);
            //phoneNumber.Text = phoneBook[_name].Text;
            string text = name.Text;
            if(!String.IsNullOrEmpty(text))
            {
                Name _name = new Name(text);
                string phone = phoneBook[_name].Text;
                phoneNumber.Text = String.IsNullOrEmpty(phone) ? "Not Found" : phone; 
            }
        }

        private void findByPhoneNumberClick(object sender, RoutedEventArgs e)
        {
            //PhoneNumber phone = new PhoneNumber(phoneNumber.Text);
            //name.Text = phoneBook[phone].Text;
            string phone = phoneNumber.Text;
            if(!String.IsNullOrEmpty(phone))
            {
                PhoneNumber phone_n = new PhoneNumber(phoneNumber.Text);
                string name_str = phoneBook[phone_n].Text;
                name.Text = String.IsNullOrEmpty(name_str) ? "Not Found" : name_str;
            }
        }

        private void addClick(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(name.Text) && !String.IsNullOrEmpty(phoneNumber.Text))
            {
                phoneBook.Add(new Name(name.Text),
                              new PhoneNumber(phoneNumber.Text));
                name.Text = "";
                phoneNumber.Text = "";
            }
        }
    }
}
