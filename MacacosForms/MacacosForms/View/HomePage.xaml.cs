
using Xamarin.Forms;

namespace MacacosForms.View
{
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			BindingContext = new MacacoViewModel();
			InitializeComponent();
		}
	}
}

