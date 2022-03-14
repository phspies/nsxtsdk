// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public long? SslCacheSize { get; set; }
    }
}
