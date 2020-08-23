using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppProfit
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

		}

		
		async private void BtnIniciar_Clicked(object sender, EventArgs e)
		{

			int Usuario = Convert.ToInt32(TxtUser.Text);
			var Contraseña = TxtPassword.Text;

			if (Usuario == 9680 && Contraseña == "Profit01")
			{
				await DisplayAlert("Inicio de sesión", "¡Sesión iniciada correctamente!", "Ok");
				TxtUser.Text = "";
				TxtPassword.Text = "";

				await Navigation.PushModalAsync(new MenuPrincipal());

			}
			else
			{
				await DisplayAlert("¡Error!", "El usuario o contraseña ingresada no es la correcta," +
					" favor de ingresar un usuario o contraseña válidos.", "Ok");

				TxtUser.Text = "";
				TxtPassword.Text = "";

				return;
			}
		}
	}
}
