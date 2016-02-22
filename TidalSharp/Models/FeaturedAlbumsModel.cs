// Visual Studio Extension "JsonUtilsToolbar" created by Jonathan "Pwnoz0r" Rainier - Initial Servers LLC. - 2015
// Generated using Xamasoft JSON Class Generator Lib - http://www.xamasoft.com/json-class-generator

/* 
    URL: /featured/new/albums?limit=25&countryCode={CountryCode}
    REQUEST-TYPE: GET
*/

using System.Collections.Generic;
using Newtonsoft.Json;
using TidalSharp.Models.Static;

namespace TidalSharp.Models
{

    public class FeaturedAlbumsModel
    {

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("totalNumberOfItems")]
        public int TotalNumberOfItems { get; set; }

        [JsonProperty("items")]
        public IList<Item> Items { get; set; }
    }

}
