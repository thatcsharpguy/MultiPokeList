using System;

using Xamarin.Forms;
using MultiPokeListView.ViewModels;
using MultiPokeListView.Controls;

namespace MultiPokeListView.Pages
{
    public class PokemonListPage : ContentPage
    {
        public PokemonListPage()
        {
            BindingContext = (App.Current as App).PokemonsViewModel;
			Title = "Pokemon";

            var list = new ListView();
            list.SetBinding(ListView.ItemsSourceProperty, "Pokemons");

            var template = new DataTemplate(typeof(PokemonSelectableCell));
            template.SetBinding(PokemonSelectableCell.NameProperty, "Item.Name");
            template.SetBinding(PokemonSelectableCell.WeightProperty, "Item.Weight");
            template.SetBinding(PokemonSelectableCell.HeightProperty, "Item.Height");
            list.ItemTemplate = template;

            var getSelectedItemsButton = new ToolbarItem()
            { 
                Text = "Elegir"
            };
            getSelectedItemsButton.SetBinding(ToolbarItem.CommandProperty, "GetSelectedItemsCommand");
            ToolbarItems.Add(getSelectedItemsButton);

            Content = list;
        }
    }
}


