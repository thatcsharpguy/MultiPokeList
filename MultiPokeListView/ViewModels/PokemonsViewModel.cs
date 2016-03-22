using System;
using System.Linq;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using MultiPokeListView.Pages;

namespace MultiPokeListView.ViewModels
{
    public class PokemonsViewModel : INotifyPropertyChanged
    {
        public PokemonsViewModel()
        {
            var pokemones = new List<Pokemon>()
            {
            #region Pokemons
                    new Pokemon { Id = 1, Name = "Bulbasaur", Height = 0.7, Weight = 6.9 },
                    new Pokemon { Id = 2, Name = "Ivysaur", Height = 1, Weight = 13 },
                    new Pokemon { Id = 3, Name = "Venusaur", Height = 2, Weight = 100 },
                    new Pokemon { Id = 4, Name = "Charmander", Height = 0.6, Weight = 8.5 },
                    new Pokemon { Id = 5, Name = "Charmeleon", Height = 1.1, Weight = 19 },
                    new Pokemon { Id = 6, Name = "Charizard", Height = 1.7, Weight = 90.5 },
                    new Pokemon { Id = 7, Name = "Squirtle", Height = 0.5, Weight = 9 },
                    new Pokemon { Id = 8, Name = "Wartortle", Height = 1, Weight = 22.5 },
                    new Pokemon { Id = 9, Name = "Blastoise", Height = 1.6, Weight = 85.5 },
                    new Pokemon { Id = 10, Name = "Caterpie", Height = 0.3, Weight = 2.9 },
                    new Pokemon { Id = 11, Name = "Metapod", Height = 0.7, Weight = 9.9 },
                    new Pokemon { Id = 12, Name = "Butterfree", Height = 1.1, Weight = 32 },
                    new Pokemon { Id = 13, Name = "Weedle", Height = 0.3, Weight = 3.2 },
                    new Pokemon { Id = 14, Name = "Kakuna", Height = 0.6, Weight = 10 },
                    new Pokemon { Id = 15, Name = "Beedrill", Height = 1, Weight = 29.5 },
                    new Pokemon { Id = 16, Name = "Pidgey", Height = 0.3, Weight = 1.8 },
                    new Pokemon { Id = 17, Name = "Pidgeotto", Height = 1.1, Weight = 30 },
                    new Pokemon { Id = 18, Name = "Pidgeot", Height = 1.5, Weight = 39.5 },
					new Pokemon { Id = 19, Name = "Rattata", Height = 0.3, Weight = 3.5 },
                    new Pokemon { Id = 20, Name = "Raticate", Height = 0.7, Weight = 18.5 },
                    new Pokemon { Id = 21, Name = "Spearow", Height = 0.3, Weight = 2 },
                    new Pokemon { Id = 22, Name = "Fearow", Height = 1.2, Weight = 38 },
                    new Pokemon { Id = 23, Name = "Ekans", Height = 2, Weight = 6.9 },
                    new Pokemon { Id = 24, Name = "Arbok", Height = 3.5, Weight = 65 },
                    new Pokemon { Id = 25, Name = "Pikachu", Height = 0.4, Weight = 6 },
                    new Pokemon { Id = 26, Name = "Raichu", Height = 0.8, Weight = 30 },
                    new Pokemon { Id = 27, Name = "Sandshrew", Height = 0.6, Weight = 12 },
                    new Pokemon { Id = 28, Name = "Sandslash", Height = 1, Weight = 29.5 },
                    new Pokemon { Id = 29, Name = "Nidoran-F", Height = 0.4, Weight = 7 },
                    new Pokemon { Id = 30, Name = "Nidorina", Height = 0.8, Weight = 20 },
                    new Pokemon { Id = 31, Name = "Nidoqueen", Height = 1.3, Weight = 60 },
                    new Pokemon { Id = 32, Name = "Nidoran-M", Height = 0.5, Weight = 9 },
                    new Pokemon { Id = 33, Name = "Nidorino", Height = 0.9, Weight = 19.5 },
                    new Pokemon { Id = 34, Name = "Nidoking", Height = 1.4, Weight = 62 },
                    new Pokemon { Id = 35, Name = "Clefairy", Height = 0.6, Weight = 7.5 },
                    new Pokemon { Id = 36, Name = "Clefable", Height = 1.3, Weight = 40 },
                    new Pokemon { Id = 37, Name = "Vulpix", Height = 0.6, Weight = 9.9 },
                    new Pokemon { Id = 38, Name = "Ninetales", Height = 1.1, Weight = 19.9 },
                    new Pokemon { Id = 39, Name = "Jigglypuff", Height = 0.5, Weight = 5.5 },
                    new Pokemon { Id = 40, Name = "Wigglytuff", Height = 1, Weight = 12 },
                    new Pokemon { Id = 41, Name = "Zubat", Height = 0.8, Weight = 7.5 },
                    new Pokemon { Id = 42, Name = "Golbat", Height = 1.6, Weight = 55 },
                    new Pokemon { Id = 43, Name = "Oddish", Height = 0.5, Weight = 5.4 },
                    new Pokemon { Id = 44, Name = "Gloom", Height = 0.8, Weight = 8.6 },
                    new Pokemon { Id = 45, Name = "Vileplume", Height = 1.2, Weight = 18.6 },
                    new Pokemon { Id = 46, Name = "Paras", Height = 0.3, Weight = 5.4 },
                    new Pokemon { Id = 47, Name = "Parasect", Height = 1, Weight = 29.5 },
                    new Pokemon { Id = 48, Name = "Venonat", Height = 1, Weight = 30 },
                    new Pokemon { Id = 49, Name = "Venomoth", Height = 1.5, Weight = 12.5 },
                    new Pokemon { Id = 50, Name = "Diglett", Height = 0.2, Weight = 0.8 },
                    new Pokemon { Id = 51, Name = "Dugtrio", Height = 0.7, Weight = 33.3 },
                    new Pokemon { Id = 52, Name = "Meowth", Height = 0.4, Weight = 4.2 },
                    new Pokemon { Id = 53, Name = "Persian", Height = 1, Weight = 32 },
                    new Pokemon { Id = 54, Name = "Psyduck", Height = 0.8, Weight = 19.6 },
                    new Pokemon { Id = 55, Name = "Golduck", Height = 1.7, Weight = 76.6 },
            #endregion
            };

            Pokemons = new ObservableCollection<SelectableItemWrapper<Pokemon>>(pokemones
                .Select(pk => new SelectableItemWrapper<Pokemon> { Item = pk }));
        }
        
        private ObservableCollection<SelectableItemWrapper<Pokemon>> _pokemons;
        public ObservableCollection<SelectableItemWrapper<Pokemon>> Pokemons
        {
            get { return _pokemons; }
            set { _pokemons = value; RaisePropertyChanged(); }
        }

		private ObservableCollection<Pokemon> _selectedPokemons;
		public ObservableCollection<Pokemon> SelectedPokemons
		{
			get { return _selectedPokemons ?? new ObservableCollection<Pokemon>(); }
			private set { _selectedPokemons = value; RaisePropertyChanged(); }
		}

		#region Commands

		private ICommand _getSelectedItemsCommand;
		public ICommand GetSelectedItemsCommand
		{
			get
			{
				return _getSelectedItemsCommand ??
					(_getSelectedItemsCommand = new Command(
						async () =>
						{
                            SelectedPokemons = GetSelectedPokemons();
                            // Navigation is not 
                            await App.Current.MainPage.Navigation.PushAsync(new SelectedPokemonPage());
						}));
			}
		}

		#endregion


		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        ObservableCollection<Pokemon> GetSelectedPokemons()
        {
            var selected = Pokemons
                .Where(p => p.IsSelected)
                .Select(p => p.Item)
                .ToList();   
            return new ObservableCollection<Pokemon>(selected);
        }

        void SelectAll(bool select)
        {
            foreach (var p in Pokemons)
            {
                p.IsSelected = select;
            }
        }

        void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}


