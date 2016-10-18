using System;
using System.Collections.Generic;
using MacacosForms.Model;
using Xamarin.Forms;

namespace MacacosForms
{
	public partial class MasterDetailsPage : ContentPage
	{
		public MasterDetailsPage(Macaco monkey)
		{
			InitializeComponent();
			BindingContext = monkey;
			Title = monkey.Apelido;
		}
	}
}
