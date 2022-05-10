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
    /// Advanced load balancer HttpCookiePersistenceKey object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HttpCookiePersistenceKey object")]
    public class NSXTALBHttpCookiePersistenceKeyType 
    {
        /// <summary>
        /// hmac_key of HttpCookiePersistenceKey.
        /// </summary>
        [JsonProperty(PropertyName = "hmac_key")]
        public string? HmacKey { get; set; }
        /// <summary>
        /// name to use for cookie encryption.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// aes_key of HttpCookiePersistenceKey.
        /// </summary>
        [JsonProperty(PropertyName = "aes_key")]
        public string? AesKey { get; set; }
    }
}
