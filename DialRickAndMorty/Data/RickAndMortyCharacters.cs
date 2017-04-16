using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace DialRickAndMorty
{
	public class RickAndMortyCharacters : ContentPage
	{
		public static IList<Person> Characters { get; private set; }

		static RickAndMortyCharacters()
		{
			Characters = new List<Person> {
				new Person {
					Name = "Rick Sanchez",
					HeadshotUrl = "rick.gif",
					Email = "Wubbalubbadubdub@gmail.com",
					Dob = new DateTime(1957, 1, 1),
					Gender = Gender.Male,
					IsFavorite = false,
				},
				new Person {
					Name = "Mortimer Smith",
					HeadshotUrl = "morty.gif",
					Email = "morty@gmail.com",
					Dob = new DateTime(2003, 8, 4),
					Gender = Gender.Male,
					IsFavorite = true,
				},
				new Person {
					Name = "Mr Poopybutthole",
					HeadshotUrl = "poopy.gif",
					Email = "Oo-wee@gmail.com",
					Dob = new DateTime(1750, 3, 2),
					Gender = Gender.Male,
					IsFavorite = true,
				},
				new Person {
					Name = "Birdperson",
					HeadshotUrl = "bird.gif",
					Email = "phoenix@gmail.com",
					Dob = new DateTime(1977, 3, 1),
					Gender = Gender.Male,
					IsFavorite = true,
				},
				new Person {
					Name = "Diane Sanchez",
					HeadshotUrl = "diane.gif",
					Email = "dianez@gmail.com",
					Dob = new DateTime(1960, 5, 12),
					Gender = Gender.Female,
					IsFavorite = true,
				},
				new Person {
					Name = "Jerry Smith",
					HeadshotUrl = "jerry.gif",
					Email = "elgringo@gmail.com",
					Dob = new DateTime(1983, 11, 18),
					Gender = Gender.Male,
					IsFavorite = true,
				},
				new Person {
					Name = "Evil Morty",
					HeadshotUrl = "evil.gif",
					Email = "deadeye@gmail.com",
					Dob = new DateTime(2003, 8, 3),
					Gender = Gender.Male,
					IsFavorite = true,
				},
				new Person {
					Name = "Mr Meeseeks",
					HeadshotUrl = "meeseeks.gif",
					Email = "lookatme@gmail.com",
					Dob = new DateTime(2017, 6, 4),
					Gender = Gender.Male,
					IsFavorite = true,
				},
			};
		}
	}
}
