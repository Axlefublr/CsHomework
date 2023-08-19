namespace Greetings;

internal class Program
{
   private static void Main(string[] args)
   {
      User user1 = new()
      {
         Login = "login",
         Name = "Mark",
         IsPremium = false
      };
      User user2 = new()
      {
         Login = "myfavoritecat",
         Name = "Alex",
         IsPremium = true
      };
      User user3 = new()
      {
         Login = "goblinmode",
         Name = "Aaron",
         IsPremium = false
      };
      List<User> users = new() { user1, user2, user3 };

      Greet(users);
   }

   static void Greet(List<User> users)
   {
      foreach (User user in users) {
         Console.WriteLine("Omg hewwo " + user.Name + "!");
         if (!user.IsPremium) {
            ShowAds();
         }
      }
   }

   static void ShowAds()
   {
      string[] ads = {
         "Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com",
         "Купите подписку на МыКомбо и слушайте музыку везде и всегда.",
         "Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу."
      };

      foreach (string ad in ads)
      {
         Console.WriteLine(ad);
         Thread.Sleep(1000);
      }
   }
}