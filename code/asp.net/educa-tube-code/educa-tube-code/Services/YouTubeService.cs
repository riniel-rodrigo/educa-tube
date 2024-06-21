using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml;
using Video = educa_tube_code.Models.Video;

namespace educa_tube_code.Services
{
    public class YouTubeApiService
    {
        private readonly string _apiKey;

        public YouTubeApiService(string apiKey)
        {
            _apiKey = apiKey;
        }

        public async Task<List<Video>> SearchVideosAsync(string query, int maxResults = 10)
        {
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = _apiKey,
                ApplicationName = this.GetType().ToString()
            });

            var searchListRequest = youtubeService.Search.List("snippet");
            searchListRequest.Q = query;
            searchListRequest.MaxResults = maxResults;

            var searchListResponse = await searchListRequest.ExecuteAsync();

            var videos = new List<Video>();

            foreach (var searchResult in searchListResponse.Items)
            {
                if (searchResult.Id.Kind == "youtube#video")
                {
                    var thumbnailUrl = searchResult.Snippet.Thumbnails.Maxres?.Url ??
                                       searchResult.Snippet.Thumbnails.High?.Url ??
                                       searchResult.Snippet.Thumbnails.Medium?.Url ??
                                       searchResult.Snippet.Thumbnails.Default__.Url;

                    var video = new Video
                    {
                        Titulo = searchResult.Snippet.Title,
                        Url = $"https://www.youtube.com/watch?v={searchResult.Id.VideoId}",
                        Descricao = searchResult.Snippet.Description,
                        ThumbnailUrl = thumbnailUrl, // Use the best quality thumbnail
                        DataCadastro = DateTime.Now,
                        VideoId = searchResult.Id.VideoId,
                        DatePublished = searchResult.Snippet.PublishedAtDateTimeOffset?.DateTime ?? DateTime.MinValue,
                        ChannelTitle = searchResult.Snippet.ChannelTitle
                    };

                    var videoListRequest = youtubeService.Videos.List("statistics,snippet,contentDetails");
                    videoListRequest.Id = searchResult.Id.VideoId;

                    var videoListResponse = await videoListRequest.ExecuteAsync();
                    var videoDetails = videoListResponse.Items[0];

                    video.ViewCount = (long)(videoDetails.Statistics.ViewCount ?? 0);
                    video.LikeCount = (long)(videoDetails.Statistics.LikeCount ?? 0);
                    video.Duration = ConvertDuration(videoDetails.ContentDetails.Duration);

                    var channelListRequest = youtubeService.Channels.List("snippet");
                    channelListRequest.Id = videoDetails.Snippet.ChannelId;

                    var channelListResponse = await channelListRequest.ExecuteAsync();
                    var channelDetails = channelListResponse.Items[0];

                    video.ChannelThumbnailUrl = channelDetails.Snippet.Thumbnails.Default__.Url;

                    videos.Add(video);
                }
            }

            return videos;
        }

        public async Task<List<Video>> GetSpecificVideosAsync(List<string> videoIds)
        {
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = _apiKey,
                ApplicationName = this.GetType().ToString()
            });

            var videoListRequest = youtubeService.Videos.List("snippet,contentDetails,statistics");
            videoListRequest.Id = string.Join(",", videoIds);

            var videoListResponse = await videoListRequest.ExecuteAsync();

            var videos = new List<Video>();

            foreach (var videoDetails in videoListResponse.Items)
            {
                var thumbnailUrl = videoDetails.Snippet.Thumbnails.Maxres?.Url ??
                                   videoDetails.Snippet.Thumbnails.High?.Url ??
                                   videoDetails.Snippet.Thumbnails.Medium?.Url ??
                                   videoDetails.Snippet.Thumbnails.Default__.Url;

                var video = new Video
                {
                    Titulo = videoDetails.Snippet.Title,
                    Url = $"https://www.youtube.com/watch?v={videoDetails.Id}",
                    Descricao = videoDetails.Snippet.Description,
                    ThumbnailUrl = thumbnailUrl,
                    DataCadastro = DateTime.Now,
                    VideoId = videoDetails.Id,
                    DatePublished = videoDetails.Snippet.PublishedAtDateTimeOffset?.DateTime ?? DateTime.MinValue,
                    ChannelTitle = videoDetails.Snippet.ChannelTitle,
                    ViewCount = (long)(videoDetails.Statistics.ViewCount ?? 0),
                    LikeCount = (long)(videoDetails.Statistics.LikeCount ?? 0),
                    Duration = ConvertDuration(videoDetails.ContentDetails.Duration),
                    ChannelThumbnailUrl = videoDetails.Snippet.Thumbnails.Default__.Url
                };

                videos.Add(video);
            }

            return videos;
        }

        private string ConvertDuration(string duration)
        {
            var timeSpan = XmlConvert.ToTimeSpan(duration);
            return timeSpan.ToString(@"hh\:mm\:ss");
        }
    }
}
