// Visual Studio Extension "JsonUtilsToolbar" created by Jonathan "Pwnoz0r" Rainier - Initial Servers LLC. - 2016
// Generated using Xamasoft JSON Class Generator Lib - http://www.xamasoft.com/json-class-generator

/*
    URL: /albums/{AlbumId}/tracks?sessionId={SessionId}&countryCode={CountryCode}
    REQUEST-TYPE: GET
*/

using System.Collections.Generic;
using Newtonsoft.Json;
using TidalSharp.Models.Static;

namespace TidalSharp.Models
{

    public class AlbumTracksModel
    {

        [JsonProperty("limit")]
        public int Limit;

        [JsonProperty("offset")]
        public int Offset;

        [JsonProperty("totalNumberOfItems")]
        public int TotalNumberOfItems;

        [JsonProperty("items")]
        public IList<TracksItem> Items;
    }

}
