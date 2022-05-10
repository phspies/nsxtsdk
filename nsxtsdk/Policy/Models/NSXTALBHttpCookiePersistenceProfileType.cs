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
    /// Advanced load balancer HttpCookiePersistenceProfile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HttpCookiePersistenceProfile object")]
    public class NSXTALBHttpCookiePersistenceProfileType 
    {
        /// <summary>
        /// HTTP cookie name for cookie persistence.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_name")]
        public string? CookieName { get; set; }
        /// <summary>
        /// If no persistence cookie was received from the client,
        /// always send it.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "always_send_cookie")]
        public bool? AlwaysSendCookie { get; set; }
        /// <summary>
        /// Placeholder for description of property key of obj type
        /// HttpCookiePersistenceProfile field type str  type array.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public IList<NSXTALBHttpCookiePersistenceKeyType> Key { get; set; }
        /// <summary>
        /// The maximum lifetime of any session cookie.
        /// No value or 'zero' indicates no timeout.
        /// Allowed values are 1-14400.
        /// Special values are 0- 'No Timeout'.
        /// Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        public long? Timeout { get; set; }
        /// <summary>
        /// Key name to use for cookie encryption.
        /// </summary>
        [JsonProperty(PropertyName = "encryption_key")]
        public string? EncryptionKey { get; set; }
    }
}
