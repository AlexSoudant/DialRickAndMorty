using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DialRickAndMorty
{
	public partial class RickAndMortyDetails : ContentPage
	{
		Person tappedPerson;

		public RickAndMortyDetails()
		{
			InitializeComponent();
		}

		public RickAndMortyDetails(Person tappedPerson)
		{
			this.tappedPerson = tappedPerson;
		}
	}
}
