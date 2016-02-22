// Visual Studio Extension "JsonUtilsToolbar" created by Jonathan "Pwnoz0r" Rainier - Initial Servers LLC. - 2016
// Generated using Xamasoft JSON Class Generator Lib - http://www.xamasoft.com/json-class-generator

/* 
    URL: /users/{UserId}/subscription?countryCode={CountryCode}
    REQUEST-TYPE: GET
*/

using System;
using Newtonsoft.Json;

namespace TidalSharp.Models
{

    public class Subscription
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("offlineGracePeriod")]
        public int OfflineGracePeriod { get; set; }
    }

    public class UsersSubscriptionsModel
    {

        [JsonProperty("validUntil")]
        public DateTime ValidUntil { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("subscription")]
        public Subscription Subscription { get; set; }

        [JsonProperty("highestSoundQuality")]
        public string HighestSoundQuality { get; set; }

        [JsonProperty("premiumAccess")]
        public bool PremiumAccess { get; set; }

        [JsonProperty("canGetTrial")]
        public bool CanGetTrial { get; set; }

        [JsonProperty("paymentType")]
        public string PaymentType { get; set; }
    }

}
