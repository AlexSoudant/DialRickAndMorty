using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DialRickAndMorty
{
	public partial class RickAndMortyContacts : ContentPage
	{
		public RickAndMortyContacts()
		{
			InitializeComponent();


		}

		async void OnItemTapped(object sender, ItemTappedEventArgs e)
		{
			Person tappedPerson = (Person)e.Item;
			await this.Navigation.PushAsync(new RickAndMortyDetails(tappedPerson));
		}
	}
}
