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
    public class NSXTPolicyMetadataProxyStatisticsType 
    {
        /// <summary>
        /// timestamp of the statistics
        /// </summary>
        [JsonProperty(PropertyName = "timestamp", Required = Required.AllowNull)]
        public long Timestamp { get; set; }
        /// <summary>
        /// Policy path of metadata proxy configuration
        /// </summary>
        [JsonProperty(PropertyName = "metadata_proxy_path", Required = Required.AllowNull)]
        public string MetadataProxyPath { get; set; }
        /// <summary>
        /// Metadata Proxy statistics per segment
        /// </summary>
        [JsonProperty(PropertyName = "statistics")]
        public IList<NSXTMetadataProxyStatisticsPerSegmentType> Statistics { get; set; }
    }
}
