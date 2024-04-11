using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Linq;

namespace SportsManagementSystem
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MenuViewModel();
        }

        private void OnMenuSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var collectionView = (CollectionView)sender;
            var selectedItem = (MenuItem)e.CurrentSelection.FirstOrDefault();
            // TODO: Handle the menu item selection
            // For example, navigate to a new page based on the selected item's title
        }
    }

    public class MenuViewModel
    {
        public ObservableCollection<MenuItem> MenuItems { get; set; }

        public MenuViewModel()
        {
            // Initialize with some default menu items
            MenuItems = new ObservableCollection<MenuItem>
            {
                new MenuItem { Title = "Dashboard" },
                new MenuItem { Title = "Profile" },
                new MenuItem { Title = "Product" },
				new MenuItem { Title = "Users" }
                // Add more items here as needed
            };
        }
    }

    public class MenuItem
    {
        public string Title { get; set; }
        // You can add ICommand property if you want to handle the click event on each menu item
    }
}
