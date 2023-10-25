using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaCastException.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";
    [ObservableProperty]
    private int viewOneZIndex  = 0;

    [ObservableProperty]
    private int viewTwoZIndex = -1;

    [RelayCommand]
    public void ShowOneClick()
    {
        ViewOneZIndex = 0;
        ViewTwoZIndex = -1;
    }

    public void ShowTwoClick()
    {
        ViewOneZIndex = -1;
        ViewTwoZIndex = 0;
    }
}
