namespace jchusinExamen.Vistas;

public partial class vGrid : ContentPage
{
    // Definir un diccionario para almacenar usuarios y contraseñas
    Dictionary<string, string> credentials = new Dictionary<string, string>
    {
        { "estudiante2024", "uisrael2024" },
        { "examen1", "parcial1" },
        { "NombreEstudiante", "2024" }
    };
    public vGrid()
	{
		InitializeComponent();
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        bool isAuthenticated = false;

        // Verificar las credenciales en el diccionario
        if (credentials.ContainsKey(username) && credentials[username] == password)
        {
            isAuthenticated = true;
            DisplayAlert("¡Bienvenido!", $"¡Bienvenido {username}!", "OK");
            Navigation.PushAsync(new vRegistro(username));
        }

        if (!isAuthenticated)
        {
            DisplayAlert("Error", "Nombre de usuario o contraseña incorrectos", "OK");
        }
    

}

    
    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vAcerca());

    }
}