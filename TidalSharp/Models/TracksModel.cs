// Visual Studio Extension "JsonUtilsToolbar" created by Jonathan "Pwnoz0r" Rainier - Initial Servers LLC. - 2016
// Generated using Xamasoft JSON Class Generator Lib - http://www.xamasoft.com/json-class-generator

/*
    URL: /tracks/{TrackId}/streamUrl?soundQuality={SoundQuality}&sessionId={SessionId}&countryCode={CountryCode}
    REQUEST-TYPE: GET
*/

using Newtonsoft.Json;

namespace TidalSharp.Models
{

    public class TracksModel
    {

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("trackId")]
        public int TrackId { get; set; }

        [JsonProperty("playTimeLeftInMinutes")]
        public int PlayTimeLeftInMinutes { get; set; }

        [JsonProperty("soundQuality")]
        public string SoundQuality { get; set; }

        [JsonProperty("encryptionKey")]
        public string EncryptionKey { get; set; }
    }

}
