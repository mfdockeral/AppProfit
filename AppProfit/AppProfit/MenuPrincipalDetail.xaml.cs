using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppProfit
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPrincipalDetail : ContentPage
	{
		public MenuPrincipalDetail()
		{
			InitializeComponent();
		}

		async private void BtnForm_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new NavigationPage(new FormularioMantenimiento()));
		}

		async private void BtnFromPrec_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new NavigationPage(new FormularioPrecios()));
		}

		async private void BtnFromEst_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new NavigationPage(new Estadisticas()));
		}
	}
}