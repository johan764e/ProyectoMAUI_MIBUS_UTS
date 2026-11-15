namespace MAUI_MIBUS_UTS;

public partial class EnVivoPage : ContentPage
{
    public EnVivoPage()
    {
        InitializeComponent();
    }

    private async void OnVolverClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");   // vuelve al inicio
    }
}