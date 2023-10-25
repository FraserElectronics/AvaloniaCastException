using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

using AvaloniaCastException.ViewModels;

namespace AvaloniaCastException.Views;

public partial class ViewTwo : UserControl
{
    public ViewTwo()
    {
        //
        // Comment out the line below to make the code work.
        //
        this.DataContext = new ViewTwoViewModel();
        InitializeComponent();
    }
}