namespace Practica3;

public partial class NewPage1 : ContentPage //completa
{
    public NewPage1()
    {
        InitializeComponent();
    }
    private void DetallesBTN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Detalles
        {
            BindingContext = new Class1 { Texto = "Texto de la pagina 1" }
        });
    }  
}