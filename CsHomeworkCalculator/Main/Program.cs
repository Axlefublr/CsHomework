namespace Main;
internal class Program
{
   private static void Main()
   {
      string text1 = GetInput("Type in your first number: ");
      string text2 = GetInput("Type in your second number: ");

      Logger logger = new();
      int num1;
      try {
         num1 = int.Parse(text1);
      } catch (FormatException ex) {
         logger.Error(ex.Message);
         return;
      }

      int num2;
      try {
         num2 = int.Parse(text2);
      } catch (FormatException ex) {
         logger.Error(ex.Message);
         return;
      }

      Calculator calculator = new();
      Console.WriteLine("Your result is: " + calculator.Add(num1, num2));
   }

   private static string GetInput(string message) {
      string text = "";
      while (string.IsNullOrEmpty(text)) {
         Console.Write(message);
         text = Console.ReadLine() ?? "";
      }
      return text;
   }
}