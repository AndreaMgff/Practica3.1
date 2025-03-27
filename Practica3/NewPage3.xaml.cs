namespace Practica3;

public partial class NewPage3 : ContentPage
{
	public NewPage3()
	{
		InitializeComponent();
	}
    private void DetallesBTN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Detalles
        {
            BindingContext = new Class1 { Texto = "Fenix INFO" }
        });
    }
}