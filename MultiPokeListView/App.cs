
using System;

using Xamarin.Forms;
using MultiPokeListView.ViewModels;
using MultiPokeListView.Pages;

namespace MultiPokeListView
{
    public class App : Application
    {
        public PokemonsViewModel PokemonsViewModel{ get; private set; }

        public App()
        {
            PokemonsViewModel = new PokemonsViewModel();

			#if USE_XAML
			MainPage = new NavigationPage(new PokemonListXamlPage());
			#else
			MainPage = new NavigationPage(new PokemonListPage());
			#endif

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

