using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
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
                    videos.Add(new Video
                    {
                        Titulo = searchResult.Snippet.Title,
                        Url = $"https://www.youtube.com/watch?v={searchResult.Id.VideoId}",
                        Descricao = searchResult.Snippet.Description,
                        ThumbnailUrl = searchResult.Snippet.Thumbnails.Default__.Url,
                        DataCadastro = DateTime.Now,
                        VideoId = searchResult.Id.VideoId // Preenche a propriedade VideoId
                    });
                }
            }

            return videos;
        }
    }
}