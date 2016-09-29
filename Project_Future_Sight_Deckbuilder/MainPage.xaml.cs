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

namespace Project_Future_Sight_Deckbuilder
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Home.IsSelected = true;
            BackButton.Visibility = Visibility.Collapsed;
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            Splitview.IsPaneOpen = !Splitview.IsPaneOpen;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MenuFrame.CanGoBack)
            {
                MenuFrame.GoBack();
                Home.IsSelected = true;
            }
        }

        private void MenuList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Home.IsSelected)
            {
                BackButton.Visibility = Visibility.Collapsed;
                MenuFrame.Navigate(typeof(Home));
            }
            else if (Add.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                MenuFrame.Navigate(typeof(AddDeck));
            }
            else if (EditDecks.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                MenuFrame.Navigate(typeof(Editor));
            }
            else if (Inventory.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                MenuFrame.Navigate(typeof(Inventory));
            }
            
        }

       
    }
}
