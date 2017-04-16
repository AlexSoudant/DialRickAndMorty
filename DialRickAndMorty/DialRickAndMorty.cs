using System;

using Xamarin.Forms;
using System.Linq;

namespace DialRickAndMorty
{
	public class App : Application
	{
		public App()
		{

			MainPage = new NavigationPage(new RickAndMortyContacts());
		}

	}
}
