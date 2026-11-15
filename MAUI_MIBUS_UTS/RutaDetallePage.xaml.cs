namespace MAUI_MIBUS_UTS;

// Recibe la ruta que se tocó en MainPage (clave "ruta")
[QueryProperty(nameof(Ruta), "ruta")]
public partial class RutaDetallePage : ContentPage
{
    private RutaInfo? ruta;

    public RutaInfo? Ruta
    {
        get => ruta;
        set
        {
            ruta = value;
            if (ruta == null) return;

            lblNombre.Text = $"Ruta {ruta.Nombre}";
            lblSalida.Text = ruta.Salida;
            lblLlegada.Text = ruta.Llegada;
            imgRuta.Source = ruta.Imagen;
        }
    }

    public RutaDetallePage()
    {
        InitializeComponent();
    }

    private async void OnVolverClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}