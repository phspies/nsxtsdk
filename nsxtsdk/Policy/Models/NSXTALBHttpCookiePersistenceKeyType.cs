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
    /// Advanced load balancer HttpCookiePersistenceKey object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HttpCookiePersistenceKey object")]
    public class NSXTALBHttpCookiePersistenceKeyType 
    {
        public NSXTALBHttpCookiePersistenceKeyType()
        {
        }
        /// <summary>
        /// hmac_key of HttpCookiePersistenceKey.
        /// </summary>
        [JsonProperty(PropertyName = "hmac_key")]
        [NSXTProperty(IsRequired: false, Description: @"hmac_key of HttpCookiePersistenceKey.")]
        public string? HmacKey { get; set; }
        /// <summary>
        /// name to use for cookie encryption.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [NSXTProperty(IsRequired: false, Description: @"name to use for cookie encryption.")]
        public string? Name { get; set; }
        /// <summary>
        /// aes_key of HttpCookiePersistenceKey.
        /// </summary>
        [JsonProperty(PropertyName = "aes_key")]
        [NSXTProperty(IsRequired: false, Description: @"aes_key of HttpCookiePersistenceKey.")]
        public string? AesKey { get; set; }
    }
}
