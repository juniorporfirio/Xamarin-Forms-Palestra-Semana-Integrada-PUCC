
using MacacosForms.Model;
using Xamarin.Forms;

namespace MacacosForms.View
{
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			BindingContext = new MacacoViewModel();
			Title = "Demo PUCC Campinas";
			InitializeComponent();
		}


		  void  lstMacacos_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
				return;
			
			var macaco = e.SelectedItem as Macaco;

			lstMacacos.SelectedItem = null;

			Navigation.PushAsync(new MasterDetailsPage(macaco));

		}
	}
}

