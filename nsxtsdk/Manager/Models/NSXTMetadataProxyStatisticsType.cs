using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTMetadataProxyStatisticsType 
    {
        /// <summary>
        /// timestamp of the statistics
        /// </summary>
        [JsonProperty(PropertyName = "timestamp", Required = Required.AllowNull)]
        public long Timestamp { get; set; }
        /// <summary>
        /// metadata proxy statistics per logical switch
        /// </summary>
        [JsonProperty(PropertyName = "statistics")]
        public IList<NSXTMetadataProxyStatisticsPerLogicalSwitchType> Statistics { get; set; }
        /// <summary>
        /// metadata proxy uuid
        /// </summary>
        [JsonProperty(PropertyName = "metadata_proxy_id", Required = Required.AllowNull)]
        public string MetadataProxyId { get; set; }
    }
}
