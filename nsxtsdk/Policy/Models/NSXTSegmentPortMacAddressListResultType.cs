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
    public class NSXTSegmentPortMacAddressListResultType : NSXTListResultType
    {
        public NSXTSegmentPortMacAddressListResultType()
        {
        }
        /// <summary>
        /// Timestamp when the data was last updated; unset if data source has never updated the data.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        [NSXTProperty(IsRequired: false, Description: @"Timestamp when the data was last updated; unset if data source has never updated the data.")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public IList<NSXTSegmentPortMacTableEntryType> Results { get; set; }
        /// <summary>
        /// Transport node identifier
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_id")]
        [NSXTProperty(IsRequired: false, Description: @"Transport node identifier")]
        public string? TransportNodeId { get; set; }
    }
}
