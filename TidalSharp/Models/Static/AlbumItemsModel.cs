// Visual Studio Extension "JsonUtilsToolbar" created by Jonathan "Pwnoz0r" Rainier - Initial Servers LLC. - 2016
// Generated using Xamasoft JSON Class Generator Lib - http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TidalSharp.Models.Static
{
    public class AlbumItem
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("streamReady")]
        public bool StreamReady { get; set; }

        [JsonProperty("streamStartDate")]
        public DateTime StreamStartDate { get; set; }

        [JsonProperty("allowStreaming")]
        public bool AllowStreaming { get; set; }

        [JsonProperty("premiumStreamingOnly")]
        public bool PremiumStreamingOnly { get; set; }

        [JsonProperty("numberOfTracks")]
        public int NumberOfTracks { get; set; }

        [JsonProperty("numberOfVolumes")]
        public int NumberOfVolumes { get; set; }

        [JsonProperty("releaseDate")]
        public string ReleaseDate { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("cover")]
        public string Cover { get; set; }

        [JsonProperty("explicit")]
        public bool Explicit { get; set; }

        [JsonProperty("upc")]
        public string Upc { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }

        [JsonProperty("artist")]
        public Artist Artist { get; set; }

        [JsonProperty("artists")]
        public IList<Artist> Artists { get; set; }
    }
}
