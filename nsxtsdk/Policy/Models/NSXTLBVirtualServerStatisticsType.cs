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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLBVirtualServerStatisticsType : NSXTLBVirtualServerStatisticsPerEPType
    {
        public NSXTLBVirtualServerStatisticsType()
        {
        }
        /// <summary>
        /// Timestamp when the data was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        [NSXTProperty(IsRequired: false, Description: @"Timestamp when the data was last updated.")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "statistics")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTLBStatisticsCounterType Statistics { get; set; }
        /// <summary>
        /// load balancer virtual server object path.
        /// </summary>
        [JsonProperty(PropertyName = "virtual_server_path")]
        [NSXTProperty(IsRequired: false, Description: @"load balancer virtual server object path.")]
        public string? VirtualServerPath { get; set; }
    }
}
