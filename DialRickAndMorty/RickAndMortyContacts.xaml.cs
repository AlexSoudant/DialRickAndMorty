using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DialRickAndMorty
{
	public partial class RickAndMortyContacts : ContentPage
	{
		public static IList<Person> ItemsSource { get; private set; }

		public RickAndMortyContacts()
		{
			InitializeComponent();

			RickAndMortyContacts.ItemsSource = RickAndMortyCharacters.Characters;
		}

	}
}
