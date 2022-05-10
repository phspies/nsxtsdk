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
    public class NSXTPolicyOspfDatabaseListResultType : NSXTListResultType
    {
        /// <summary>
        /// Timestamp when the data was last updated, unset if data source has never updated the data.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Policy path for Tier0 gateway
        /// </summary>
        [JsonProperty(PropertyName = "tier0_path")]
        public string? Tier0Path { get; set; }
        /// <summary>
        /// array of OSPF database data
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTOspfDatabaseStatusType> Results { get; set; }
    }
}
