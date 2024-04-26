namespace jchusinExamen.Vistas;

public partial class vAcerca : ContentPage
{
	public vAcerca()
	{
		InitializeComponent();
	}

    private void cerrar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vGrid());
    }
}