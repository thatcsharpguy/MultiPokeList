using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MultiPokeListView.Pages
{
	public partial class PokemonListXamlPage : ContentPage
    {
		public PokemonListXamlPage()
		{
			BindingContext = (App.Current as App).PokemonsViewModel;
            InitializeComponent();
        }
    }
}
