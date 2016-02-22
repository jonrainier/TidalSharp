// Visual Studio Extension "JsonUtilsToolbar" created by Jonathan "Pwnoz0r" Rainier - Initial Servers LLC. - 2016
// Generated using Xamasoft JSON Class Generator Lib - http://www.xamasoft.com/json-class-generator

/* 
    URL: /login/username?countryCode={CountryCode}
    REQUEST-TYPE: POST
    REQUEST-DATA: "username={Email}&password={Password}"
*/

using Newtonsoft.Json;

namespace TidalSharp.Models
{

    public class LoginModel
    {

        [JsonProperty("userId")]
        public int UserId { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }

}
