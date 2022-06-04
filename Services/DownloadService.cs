namespace YoutubeDownloader.Services;

public class DownloadService : IDownloadService
{
    public async void DownloadMp3(string youtubeLink)
    {
        //youtubeLink = "https://www.youtube.com/watch?v=CRQsm4ijc8U";// remove this
        if (youtubeLink == null || youtubeLink == "")
        {
            return;
        }
        var extension = ".mp3";
        var youtube = new YoutubeClient();

        var video = await youtube.Videos.GetAsync(youtubeLink);

        var downloadPath = YoutubeDownloader.Properties.Settings.Default.DownloadPath;
        var author = video.Author.ChannelTitle;
        var title = video.Title;
        var fileName = $"{author} - {title}";
        var duration = video.Duration;

        var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);

        var streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();

        FileDetailsForm fileDetails = new FileDetailsForm(title, author);
        fileDetails.ShowDialog();

        string path = Path.Combine(downloadPath, fileDetails.GetFileName() + extension);

        var stream = await youtube.Videos.Streams.GetAsync(streamInfo);


        await youtube.Videos.Streams.DownloadAsync(streamInfo, path, null);

        var tfile = TagLib.File.Create(path);
        tfile.Mode = TagLib.File.AccessMode.Write;

        tfile.Tag.Title = fileDetails.GetTitle();
        tfile.Tag.Artists = new string[] { fileDetails.GetArtist() };
        tfile.Tag.Performers = new string[] { fileDetails.GetArtist() };
        tfile.Tag.DateTagged = DateTime.Now;

        tfile.Save();
        tfile.Dispose();
    }









    public async void DownloadMp4(string youtubeLink)
    {
        var extension = ".mp4";
        var youtube = new YoutubeClient();
        // You can specify both video ID or URL
        var video = await youtube.Videos.GetAsync(youtubeLink);

        var pathToSave = YoutubeDownloader.Properties.Settings.Default.DownloadPath;
        var title = video.Title;
        var author = video.Author.ChannelTitle;
        var duration = video.Duration;

        var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);

        // Get highest quality muxed stream
        //var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

        // ...or highest bitrate audio-only stream
        var streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();

        FileDetailsForm fileDetails = new FileDetailsForm(title, author);
        fileDetails.ShowDialog();
        // ...or highest quality MP4 video-only stream
        //var streamInfo = streamManifest
        //    .GetVideoOnlyStreams()
        //    .Where(s => s.Container == Container.Mp4)
        //    .GetWithHighestVideoQuality()

        // Get the actual stream
        //var stream = await youtube.Videos.Streams.GetAsync(streamInfo);

        // Download the stream to a file
        //await youtube.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");

        //--testing
        var stream = await youtube.Videos.Streams.GetAsync(streamInfo);
        string folder = pathToSave;
        string path = Path.Combine(folder, "MAudio.mp3");
        await youtube.Videos.Streams.DownloadAsync(streamInfo, path, null);

        var tfile = TagLib.File.Create(path);
        tfile.Mode = TagLib.File.AccessMode.Write;
        tfile.Tag.Performers = null;
        tfile.Tag.Title = null;
        //TimeSpan duration = tfile.Properties.Duration;
        //Console.WriteLine("Title: {0}, duration: {1}", title, duration);

        // change title in the file
        tfile.Tag.Title = "my new title";
        tfile.Save();
    }
}






































//To retrieve metadata associated with a YouTube video, call Videos.GetAsync(...):

//    using YoutubeExplode;

//var youtube = new YoutubeClient();

//// You can specify both video ID or URL
//var video = await youtube.Videos.GetAsync("https://youtube.com/watch?v=u_yIGGhubZs");

//var title = video.Title; // "Collections - Blender 2.80 Fundamentals"
//var author = video.Author.ChannelTitle; // "Blender"
//var duration = video.Duration; // 00:07:20

//Downloading video streams
//Every YouTube video has a number of streams available, differing in containers, video quality, bit rate, frame rate, and other properties.Additionally, depending on the content of the stream, the streams are further divided into 3 categories:

//Muxed streams — contain both video and audio
//Audio-only streams — contain only audio
//Video-only streams — contain only video
//You can request the manifest that lists all available streams for a particular video by calling Videos.Streams.GetManifestAsync(...):

//    = streamManifest.GetAudioStreams().GetWithHighestBitrate();
//var videoStreamInfo = streamManifest.GetVideoStreams().First(s => s.VideoQuality.Label == "1080p60");
//var streamInfos = new IStreamInfo[] { audioStreamInfo, videoStreamInfo };

//// Download and process them into one file
//await youtube.Videos.DownloadAsync(streamInfos, new ConversionRequestBuilder("video.mp4").Build());
//Downloading closed captions
//Closed captions can be downloaded in a similar way to media streams.To get the list of available closed caption tracks, call Videos.ClosedCaptions.GetManifestAsync(...):

//using YoutubeExplode;

//var youtube = new YoutubeClient();

//var trackManifest = await youtube.Videos.ClosedCaptions.GetManifestAsync("u_yIGGhubZs");
//Then retrieve metadata for a particular track:

//// ...

//// Find closed caption track in English
//var trackInfo = trackManifest.GetByLanguage("en");
//Finally, use Videos.ClosedCaptions.GetAsync(...) to get the actual content of the track:

//// ...

//var track = await youtube.Videos.ClosedCaptions.GetAsync(trackInfo);

//// Get the caption displayed at 0:35
//var caption = track.GetByTime(TimeSpan.FromSeconds(35));
//var text = caption.Text; // "collection acts as the parent collection"
//You can also download the closed caption track in SRT file format with Videos.ClosedCaptions.DownloadAsync(...):

//// ...

//await youtube.Videos.ClosedCaptions.DownloadAsync(trackInfo, "cc_track.srt");
//Playlists
//Retrieving playlist metadata
//You can get metadata associated with a YouTube playlist by calling Playlists.GetAsync(...) method:

//using YoutubeExplode;

//var youtube = new YoutubeClient();

//var playlist = await youtube.Playlists.GetAsync("PLa1F2ddGya_-UvuAqHAksYnB0qL9yWDO6");

//var title = playlist.Title; // "First Steps - Blender 2.80 Fundamentals"
//var author = playlist.Author.ChannelTitle; // "Blender"
//Getting videos included in a playlist
//To get the videos included in a playlist, call Playlists.GetVideosAsync(...):

//using YoutubeExplode;
//using YoutubeExplode.Common;

//var youtube = new YoutubeClient();

//// Get all playlist videos
//var videos = await youtube.Playlists.GetVideosAsync("PLa1F2ddGya_-UvuAqHAksYnB0qL9yWDO6");

//// Get only the first 20 playlist videos
//var videosSubset = await youtube.Playlists
//    .GetVideosAsync(playlist.Id)
//    .CollectAsync(20);
//You can also enumerate videos lazily without waiting for the whole list to load:

//using YoutubeExplode;

//var youtube = new YoutubeClient();

//await foreach (var video in youtube.Playlists.GetVideosAsync("PLa1F2ddGya_-UvuAqHAksYnB0qL9yWDO6"))
//{
//    var title = video.Title;
//var author = video.Author;
//}
//If you need precise control over how many requests you send to YouTube, use Playlists.GetVideoBatchesAsync(...) which returns videos wrapped in batches:

//using YoutubeExplode;

//var youtube = new YoutubeClient();

//// Each batch corresponds to one request
//await foreach (var batch in youtube.Playlists.GetVideoBatchesAsync("PLa1F2ddGya_-UvuAqHAksYnB0qL9yWDO6"))
//{
//    foreach (var video in batch.Items)
//    {
//        var title = video.Title;
//        var author = video.Author;
//    }
//}
//Channels
//Retrieving channel metadata
//You can get metadata associated with a YouTube channel by calling Channels.GetAsync(...) method:

//using YoutubeExplode;

//var youtube = new YoutubeClient();

//var channel = await youtube.Channels.GetAsync("UCSMOQeBJ2RAnuFungnQOxLg");

//var title = channel.Title; // "Blender"
//You can also get channel metadata by username with Channels.GetByUserAsync(...):

//using YoutubeExplode;

//var youtube = new YoutubeClient();

//var channel = await youtube.Channels.GetByUserAsync("Blender");

//var id = channel.Id; // "UCSMOQeBJ2RAnuFungnQOxLg"
//Getting channel uploads
//To get a list of videos uploaded by a channel, call Channels.GetUploadsAsync(...):

//using YoutubeExplode;
//using YoutubeExplode.Common;

//var youtube = new YoutubeClient();

//var videos = await youtube.Channels.GetUploadsAsync("UCSMOQeBJ2RAnuFungnQOxLg");
//Searching
//You can execute a search query and get its results by calling Search.GetResultsAsync(...). Each result may represent either a video, a playlist, or a channel, so you need to apply pattern matching to handle the corresponding cases:

//using YoutubeExplode;

//var youtube = new YoutubeClient();

//await foreach (var result in youtube.Search.GetResultsAsync("blender tutorials"))
//{
//    // Use pattern matching to handle different results (videos, playlists, channels)
//    switch (result)
//    {
//        case VideoSearchResult video:
//            {
//                var id = video.Id;
//                var title = video.Title;
//                var duration = video.Duration;
//                break;
//            }
//        case PlaylistSearchResult playlist:
//            {
//                var id = playlist.Id;
//                var title = playlist.Title;
//                break;
//            }
//        case ChannelSearchResult channel:
//            {
//                var id = channel.Id;
//                var title = channel.Title;
//                break;
//            }
//    }
//}
//To limit results to a specific type, use Search.GetVideosAsync(...), Search.GetPlaylistsAsync(...), or Search.GetChannelsAsync(...):

//using YoutubeExplode;
//using YoutubeExplode.Common;

//var youtube = new YoutubeClient();

//var videos = await youtube.Search.GetVideosAsync("blender tutorials");
//var playlists = await youtube.Search.GetPlaylistsAsync("blender tutorials");
//var channels = await youtube.Search.GetChannelsAsync("blender tutorials");
//Similarly to playlists, you can also enumerate results in batches by calling Search.GetResultBatchesAsync(...):

//using YoutubeExplode;

//var youtube = new YoutubeClient();

//// Each batch corresponds to one request
//await foreach (var batch in youtube.Search.GetResultBatchesAsync("blender tutorials"))
//{
//    foreach (var result in batch.Items)
//    {
//        switch (result)
//        {
//            case VideoSearchResult videoResult:
//                {
//                    // ...
//                }
//            case PlaylistSearchResult playlistResult:
//                {
//                    // ...
//                }
//            case ChannelSearchResult channelResult:
//                {
//                    // ...
//                }
//        }
//    }
//}
