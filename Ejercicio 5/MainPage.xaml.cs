namespace Ejercicio_5;
///<Summary>
///<Createddate>2023/06/19</Createddate>
///<company>Ejercicio 5</company>
///<lastmodificationdate>2023/06/20</lastmodificationdate>
///<lastmodificationdescription>
///agregamos mensaje de salida
///</lastmodificationdescription>
///<lastmodifierautor>Lorena Vasquez</lastmodifierautor>
///</Summary>
public partial class MainPage : ContentPage
{
	///<summary>
	///constructor de la clase 
	///</summary>
	public MainPage()
	{
		InitializeComponent();
	}
	/// <summary>
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void CounterBtn_Clicked(object sender, EventArgs e)
	{
		//ademas de las variables de h y b, usaremos las variables de perimetro y superficie
		//luego colocamos peri y super, para poder imprimir los resultados, ademas
		//de colocar IsEnabled, para que los resultados no se puedan cambiar, al igual que se agraga
		//un DisplayAlert para mandar un mensaje de error si el campo esta vacio.
		if (!string.IsNullOrEmpty(h.Text) || !string.IsNullOrEmpty(b.Text))
		{
			double Altura, Base, Super, Peri;

			Altura= Convert.ToDouble(h.Text);
			Base= Convert.ToDouble(b.Text);

			Peri = 2 * (Base + Altura);
			Super = Base * Altura;

			Perimetro.Text=Peri.ToString();
			Superficie.Text=Super.ToString();
		}
		else
		{
			DisplayAlert("Error", "Ocurrio un error al ingresar los datos requeridos", "Ok");
		}

	}
}

