namespace jchusinExamen.Vistas;

public partial class vRegistro : ContentPage
{
	public vRegistro(string usuario)
	{
		InitializeComponent();
        lblusuario.Text = "Usuario conectado: " + usuario;
    }

   

    private void btnCalculo_Clicked(object sender, EventArgs e)
    {
        // Verificar si el campo txtInicial está vacío o no es un número válido
        if (string.IsNullOrWhiteSpace(txtInicial.Text) || !double.TryParse(txtInicial.Text, out double montoInicial))
        {
            DisplayAlert("Error", "Ingrese un monto inicial válido.", "OK");
            return;
        }

        // Verificar si el monto inicial es mayor que cero y menor que 1500
        if (montoInicial <= 0 || montoInicial >= 1500)
        {
            DisplayAlert("Error", "El monto inicial debe ser mayor que 0 y menor que 1500.", "OK");
            return;
        }

        // Calcular el pago mensual
        double costo = 1500;
        double pagoMensual = ((costo - montoInicial) / 4) + (costo * 0.04 / 100);

        // Mostrar el resultado en el campo txtPagomensual
        txtPagomensual.Text = pagoMensual.ToString();

    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        string usuario = lblusuario.Text;
        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        string edad = txtEdad.Text;
        string fecha = datePicker.Date.ToString("dd/MM/yyyy");
        string ciudad = pickerCiudad.SelectedItem.ToString();
        string pais = pickerPais.SelectedItem.ToString();
        string montoInicial = txtInicial.Text;
        string pagoMensual = txtPagomensual.Text;

        // Pasar los valores a la página de resumen
        Navigation.PushAsync(new vResumen(usuario, nombre, apellido, edad, fecha, ciudad, pais, montoInicial, pagoMensual));

            

    }
}