using System.Collections.ObjectModel;
public class MenuViewModel
{
    public ObservableCollection<MenuItem> MenuItems { get; set; }

    public MenuViewModel()
    {
        MenuItems = new ObservableCollection<MenuItem>
        {
            new MenuItem { Title = "Dashboard" },
            new MenuItem { Title = "Profile" },
            new MenuItem { Title = "Product" },
            new MenuItem { Title = "Users" }
            // Add or remove items dynamically as needed
        };
    }
}

public class MenuItem
{
    public required string Title { get; set; }
}
