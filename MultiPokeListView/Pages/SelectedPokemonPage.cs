using System;

using Xamarin.Forms;

namespace MultiPokeListView.Pages
{
    public class SelectedPokemonPage : ContentPage
    {
        public SelectedPokemonPage()
        {
            BindingContext = (App.Current as App).PokemonsViewModel;
            Title = "Elegidos";

            var selectedListView = new ListView();
            selectedListView.SetBinding(ListView.ItemsSourceProperty, "SelectedPokemons");

            var textCell = new DataTemplate(typeof(TextCell));
            textCell.SetBinding(TextCell.TextProperty, "Name");
            selectedListView.ItemTemplate = textCell;

            Content = selectedListView;
        }
    }
}


