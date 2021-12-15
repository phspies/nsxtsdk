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
    public class NSXTOspfNeighborsStatusListResultType : NSXTListResultType
    {
        /// <summary>
        /// Policy path to Tier0 gateway.
        /// </summary>
        [JsonProperty(PropertyName = "gateway_path", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Policy path to Tier0 gateway.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string GatewayPath { get; set; }
        /// <summary>
        /// Timestamp when the data was last updated, unset if data source has never updated the data.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        [NSXTProperty(IsRequired: false, Description: @"Timestamp when the data was last updated, unset if data source has never updated the data.")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public IList<NSXTOspfNeighborType> Results { get; set; }
    }
}
