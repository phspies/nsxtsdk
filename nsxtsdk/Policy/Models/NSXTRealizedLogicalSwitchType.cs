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
    public class NSXTRealizedLogicalSwitchType : NSXTPolicyRealizedResourceType
    {
        /// <summary>
        /// Transport zone identifier
        /// </summary>
        [JsonProperty(PropertyName = "transport_zone_id")]
        public string? TransportZoneId { get; set; }
        /// <summary>
        /// Id of the logical switch
        /// </summary>
        [JsonProperty(PropertyName = "logical_switch_id")]
        public string? LogicalSwitchId { get; set; }
    }
}
