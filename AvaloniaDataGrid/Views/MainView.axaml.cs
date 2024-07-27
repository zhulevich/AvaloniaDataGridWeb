using Avalonia.Controls;
using AvaloniaDataGrid.ViewModels;

namespace AvaloniaDataGrid.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        DataContext = new MainWindowViewModel();
        InitializeComponent();
    }
}