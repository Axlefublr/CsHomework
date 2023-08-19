using YoutubeExplode;
using YoutubeExplode.Converter;

namespace YoutubeExplodeApp;

public static class VideoInteractor {
    private static YoutubeClient.Videos youtubeConnection = YoutubeConnection.Connection;
    private static string outputFilePath = "testvideo.mp4";

    public static string GetInfo(string videoUrl) {
        return youtubeConnection.GetAsync(videoUrl);
    }

    public static async void Download(string videoUrl) {
        await youtubeConnection.DownloadAsync(videoUrl, outputFilePath, builder => builder.SetPreset(ConversionPreset.UltraFast));
    }
}