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
    public class NSXTOspfNeighborsStatusListResultType : NSXTListResultType
    {
        /// <summary>
        /// Policy path to Tier0 gateway.
        /// </summary>
        [JsonProperty(PropertyName = "gateway_path", Required = Required.AllowNull)]
        public string GatewayPath { get; set; }
        /// <summary>
        /// Timestamp when the data was last updated, unset if data source has never updated the data.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTOspfNeighborType> Results { get; set; }
    }
}
