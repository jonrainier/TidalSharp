// Visual Studio Extension "JsonUtilsToolbar" created by Jonathan "Pwnoz0r" Rainier - Initial Servers LLC. - 2016
// Generated using Xamasoft JSON Class Generator Lib - http://www.xamasoft.com/json-class-generator

/*
    URL: /users/{UserId}?countryCode={CountryCode}
    REQUEST-TYPE: GET
*/

using System;
using Newtonsoft.Json;

namespace TidalSharp.Models
{

    public class UsersModel
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("picture")]
        public object Picture { get; set; }

        [JsonProperty("newsletter")]
        public bool Newsletter { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("facebookUid")]
        public int FacebookUid { get; set; }
    }

}
