using System;

namespace Module12
{
	class User
	{
		public string Login { get; set; }
		public string Name { get; set; }
		public bool IsPremium { get; set; }

		public User(string name, string login, bool premium)
        {
			Name = name;
			Login = login;
			IsPremium = premium;
        }
	}

	class Class1
    {
		static void Main()
        {
			User Ivan = new User("Ivan", "Killer666", true);
			User Sveta = new User("Svetlana", "Queen", false);
			User Oleg = new User("Oleg", "Gigachad", false);

			User[] List = new User { Ivan, Sveta, Oleg };

			foreach (User user in List)
            {
				Greetings(user);
            }
        }
    }

	static void ShowAds()
	{
		Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
		// Остановка на 1 с
		Thread.Sleep(1000);

		Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
		// Остановка на 2 с
		Thread.Sleep(2000);

		Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
		// Остановка на 3 с
		Thread.Sleep(3000);
	}

	static void Greeting(User user)
    {
		Console.WriteLine("Привет, {0}!", user.Name);
		
		if (user.IsPremium = false)
        {
			ShowAds();
        }
    }
}