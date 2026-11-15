namespace MAUI_MIBUS_UTS;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute("permisos", typeof(PermisosPage));
        Routing.RegisterRoute("envivo", typeof(EnVivoPage));
        Routing.RegisterRoute("rutadetalle", typeof(RutaDetallePage));
    }
}