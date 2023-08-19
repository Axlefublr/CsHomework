namespace YoutubeExplodeApp;

internal class Program
{
    private static void Main(string[] args)
    {
        string definitelyNotARickroll = "https://www.youtube.com/watch?v=PzqQSOaCcnw";

        Console.WriteLine(VideoInteractor.GetInfo(definitelyNotARickroll));
        VideoInteractor.Download(definitelyNotARickroll);
    }
}