using System.Collections.ObjectModel;
using MacacosForms.Model;

namespace MacacosForms
{
	public class MacacoViewModel
	{

		public string Titulo
		{
			get;
			set;
		}

		public ObservableCollection<Macaco> Macacos
		{
			get;
			set;
		}

		public MacacoViewModel()
		{
			Titulo = "Semana Digital Xamarin";

			Macacos = new ObservableCollection<Macaco>();

			Titulo = "PUCC Campinas Xamarin Forms";

			Macacos.Add(new Macaco
			{
				Apelido = "Baboon",
				Local = "Africa & Asia",
				Descricao = "Baboons are African and Arabian Old World Macacos belonging to the genus Papio, part of the subfamily Cercopithecinae.",
				Imagem = "http://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
			});

			Macacos.Add(new Macaco
			{
				Apelido = "Capuchin Macaco",
				Local = "Central & South America",
				Descricao = "The capuchin Macacos are New World Macacos of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.",
				Imagem = "http://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
			});

			Macacos.Add(new Macaco
			{
				Apelido = "Blue Monkey",
				Local = "Central and East Africa",
				Descricao = "The blue Macaco or diademed Macaco is a species of Old World Macaco native to Central and East Africa, ranging from the upper Congo River basin east to the East African Rift and south to northern Angola and Zambia",
				Imagem = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
			});


			Macacos.Add(new Macaco
			{
				Apelido = "Squirrel Monkey",
				Local = "Central & South America",
				Descricao = "The squirrel Macacos are the New World Macacos of the genus Saimiri. They are the only genus in the subfamily Saimirinae. The Nome of the genus Saimiri is of Tupi origin, and was also used as an English Nome by early researchers.",
				Imagem = "http://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg"
			});

			Macacos.Add(new Macaco
			{
				Apelido = "Golden Lion Tamarin",
				Local = "Brazil",
				Descricao = "The golden lion tamarin also known as the golden marmoset, is a small New World Macaco of the family Callitrichidae.",
				Imagem = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Golden_lion_tamarin_portrait3.jpg/220px-Golden_lion_tamarin_portrait3.jpg"
			});

			Macacos.Add(new Macaco
			{
				Apelido = "Howler Monkey",
				Local = "South America",
				Descricao = "Howler Macacos are among the largest of the New World Macacos. Fifteen species are currently recognised. Previously classified in the family Cebidae, they are now placed in the family Atelidae.",
				Imagem = "http://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Alouatta_guariba.jpg/200px-Alouatta_guariba.jpg"
			});

			Macacos.Add(new Macaco
			{
				Apelido = "Japanese Macaque",
				Local = "Japan",
				Descricao = "The Japanese macaque, is a terrestrial Old World Macaco species native to Japan. They are also sometimes known as the snow Macaco because they live in areas where snow covers the ground for months each",
				Imagem = "http://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Macaca_fuscata_fuscata1.jpg/220px-Macaca_fuscata_fuscata1.jpg"
			});	

			Macacos.Add(new Macaco
			{
				Apelido = "Mandrill",
				Local = "Southern Cameroon, Gabon, Equatorial Guinea, and Congo",
				Descricao = "The mandrill is a primate of the Old World Macaco family, closely related to the baboons and even more closely to the drill. It is found in southern Cameroon, Gabon, Equatorial Guinea, and Congo.",
				Imagem = "http://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Mandrill_at_san_francisco_zoo.jpg/220px-Mandrill_at_san_francisco_zoo.jpg"
			});

			Macacos.Add(new Macaco
			{
				Apelido = "Proboscis Monkey",
				Local = "Borneo",
				Descricao = "The proboscis Macaco or long-nosed Macaco, known as the bekantan in Malay, is a reddish-brown arboreal Old World Macaco that is endemic to the south-east Asian island of Borneo.",
				Imagem = "http://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Proboscis_Monkey_in_Borneo.jpg/250px-Proboscis_Monkey_in_Borneo.jpg"
			});

		}
	}
}

