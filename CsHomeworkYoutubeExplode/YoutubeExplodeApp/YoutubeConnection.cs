using YoutubeExplode;

namespace YoutubeExplodeApp;

public static class YoutubeConnection {
    private static YoutubeClient.Videos youtubeClient = null;

    public static YoutubeClient.Videos Connection {
        get {
            youtubeClient ??= new YoutubeClient.Videos();
            return youtubeClient;
        }
    }
}