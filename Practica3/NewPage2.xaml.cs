namespace Practica3;

public partial class NewPage2 : ContentPage //completa
{
	public NewPage2()
	{
		InitializeComponent();
	}
    /// <summary>
    /// Cambiamos los valores de la pagina secundaria Detalles.xaml pudiendo reutilizarla con todas las demas paginas del menu. En este caso añadimos la informacion del Fenrir
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DetallesBTN (object sender, EventArgs e)
	{
        Navigation.PushAsync(new Detalles
        {
            BindingContext = new Class1 { Texto = "Fenrir es un lobo gigante y feroz que desempeña un papel crucial en el Ragnarök, el fin del mundo en la mitología nórdica. Según la profecía, Fenrir se liberará y desencadenará el caos en el mundo." }
        });
    }
}