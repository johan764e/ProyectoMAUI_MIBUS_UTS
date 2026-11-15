namespace MAUI_MIBUS_UTS;

public partial class PermisosPage : ContentPage
{
    public PermisosPage()
    {
        InitializeComponent();
    }

    private async void OnPermitirClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("envivo");
    }

    private async void OnAhoraNoClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");   // regresa a MainPage
    }
}