// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Advanced load balancer HTTPClientAuthenticationParams object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPClientAuthenticationParams object")]
    public class NSXTALBHTTPClientAuthenticationParamsType 
    {
        public NSXTALBHTTPClientAuthenticationParamsType()
        {
        }
        /// <summary>
        /// type of client authentication.
        /// Enum options - HTTP_BASIC_AUTH.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [NSXTProperty(IsRequired: false, Description: @"type of client authentication.Enum options - HTTP_BASIC_AUTH.")]
        public NSXTAlbhttpclientAuthenticationParamsTypeEnumType? Type { get; set; }
        /// <summary>
        /// Basic authentication realm to present to a user along with
        /// the prompt for credentials.
        /// </summary>
        [JsonProperty(PropertyName = "realm")]
        [NSXTProperty(IsRequired: false, Description: @"Basic authentication realm to present to a user along withthe prompt for credentials.")]
        public string? Realm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "request_uri_path")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTALBStringMatchType RequestUriPath { get; set; }
        /// <summary>
        /// Auth Profile to use for validating users.
        /// It is a reference to an object of type AuthProfile.
        /// </summary>
        [JsonProperty(PropertyName = "auth_profile_path")]
        [NSXTProperty(IsRequired: false, Description: @"Auth Profile to use for validating users.It is a reference to an object of type AuthProfile.")]
        public string? AuthProfilePath { get; set; }
    }
}
