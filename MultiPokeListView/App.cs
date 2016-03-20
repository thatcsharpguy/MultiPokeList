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

			MainPage = new NavigationPage(new PokemonListPage());
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

