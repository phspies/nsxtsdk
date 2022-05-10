using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Advanced load balancer HTTPClientAuthenticationParams object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPClientAuthenticationParams object")]
    public class NSXTALBHTTPClientAuthenticationParamsType 
    {
        /// <summary>
        /// type of client authentication.
        /// Enum options - HTTP_BASIC_AUTH.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbhttpclientAuthenticationParamsTypeEnumType? Type { get; set; }
        /// <summary>
        /// Basic authentication realm to present to a user along with
        /// the prompt for credentials.
        /// </summary>
        [JsonProperty(PropertyName = "realm")]
        public string? Realm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "request_uri_path")]
        public NSXTALBStringMatchType RequestUriPath { get; set; }
        /// <summary>
        /// Auth Profile to use for validating users.
        /// It is a reference to an object of type AuthProfile.
        /// </summary>
        [JsonProperty(PropertyName = "auth_profile_path")]
        public string? AuthProfilePath { get; set; }
    }
}
