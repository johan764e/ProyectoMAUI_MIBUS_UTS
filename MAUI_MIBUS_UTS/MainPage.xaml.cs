namespace MAUI_MIBUS_UTS;

public partial class MainPage : ContentPage
{
    // Las 11 rutas del cuatrimestre sep-dic 2026
    private readonly List<RutaInfo> rutas = new()
    {
        new RutaInfo {
            Nombre = "Providencia",
            Salida = "6:35 a.m.",
            Imagen = "ruta_providencia.jpg"
        },
        new RutaInfo {
            Nombre = "Villa Bonita - Esperanza",
            Salida = "6:20 a.m.",
            Imagen = "ruta_villa_bonita_esperanza.jpg"
        },
        new RutaInfo {
            Nombre = "Villa Juárez - Tobarito", 
            Salida = "6:15 a.m.", 
            Imagen = "ruta_villa_juarez_tobarito.jpg"
        },
        new RutaInfo {
            Nombre = "Central de Autobuses",  
            Salida = "6:50 a.m.",
            Imagen = "ruta_central_autobuses.jpg"
        },
        new RutaInfo {
            Nombre = "Miravalle",  
            Salida = "6:30 a.m.", 
            Imagen = "ruta_miravalle.jpg"
        },
        new RutaInfo { 
            Nombre = "Oscar Russo Vogel", 
            Salida = "7:00 a.m.", 
            Imagen = "ruta_oscar_russo_vogel.jpg"
        },
        new RutaInfo {
            Nombre = "Fundición",      
            Salida = "6:25 a.m.", 
            Imagen = "ruta_fundicion.jpg"
        },
        new RutaInfo {
            Nombre = "Pueblo Yaqui", 
            Salida = "6:50 a.m.",
            Imagen = "ruta_pueblo_yaqui.jpg"
        },
        new RutaInfo {
            Nombre = "Cajeme",     
            Salida = "6:45 a.m.",
            Imagen = "ruta_cajeme.jpg" 
        },
        new RutaInfo {
            Nombre = "Urbi Villa",  
            Salida = "6:40 a.m.",
            Imagen = "ruta_urbi_villa.jpg" 
        },
        new RutaInfo {
            Nombre = "San Ignacio y Pueblo Yaqui", 
            Salida = "6:15 a.m.",
            Imagen = "ruta_san_ignacio_pueblo_yaqui.jpg"
        },
    };

    public MainPage()
    {
        InitializeComponent();

        BindableLayout.SetItemsSource(listaRutas, rutas);
    }

    private async void OnRutaTapped(object sender, TappedEventArgs e)
    {
        // La ruta tocada es el BindingContext de la tarjeta
        if (sender is BindableObject tarjeta && tarjeta.BindingContext is RutaInfo ruta)
        {
            await Shell.Current.GoToAsync("rutadetalle", new Dictionary<string, object>
            {
                { "ruta", ruta }
            });
        }
    }

    private async void OnVerCamionClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("permisos");
    }
}