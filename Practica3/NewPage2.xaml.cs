namespace Practica3;

public partial class NewPage2 : ContentPage //completa
{
	public NewPage2()
	{
		InitializeComponent();
	}
	private void DetallesBTN (object sender, EventArgs e)
	{
        Navigation.PushAsync(new Detalles
        {
            BindingContext = new Class1 { Texto = "Texto de la pagina 2" }
        });
    }
}