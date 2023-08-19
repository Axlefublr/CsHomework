namespace Main;

public interface ILogger {
   void Error(string message);
   void Event(string message);
}