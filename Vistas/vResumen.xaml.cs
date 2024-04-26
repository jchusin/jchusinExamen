using static System.Runtime.InteropServices.JavaScript.JSType;

namespace jchusinExamen.Vistas;
public partial class vResumen : ContentPage
{
	public vResumen(string usuario, string nombre, string apellido, string edad, string fecha, string ciudad, string pais, string montoInicial, string pagoMensual)
	{
		InitializeComponent();
        lblUsuario.Text = "Usuario conectado: " + usuario;
        lblNombre.Text = "Nombre: " + nombre;
        lblApellido.Text = "Apellido: " + apellido;
        lblEdad.Text = "Edad: " + edad;
        lblFecha.Text = "Fecha: " + fecha;
        lblCiudad.Text = "Ciudad: " + ciudad;
        lblPais.Text = "Pais: " + pais;
        lblMontoInicial.Text = "Monto Inicaial: " + montoInicial;
        lblPagoMensual.Text = "Pago Mensual: " + pagoMensual;
        



    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vGrid());
    }
}