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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTPolicyTlsConfigProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Turn on TLS cache
        /// </summary>
        [JsonProperty(PropertyName = "cache", Required = Required.AllowNull)]
        public bool Cache { get; set; }
        /// <summary>
        /// TLS SSL cache size
        /// </summary>
        [JsonProperty(PropertyName = "ssl_cache_size")]
        public long? SslCacheSize { get; set; }
    }
}
