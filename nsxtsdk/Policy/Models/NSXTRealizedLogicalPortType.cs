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
    public class NSXTRealizedLogicalPortType : NSXTPolicyRealizedResourceType
    {
        /// <summary>
        /// The id of the logical port
        /// </summary>
        [JsonProperty(PropertyName = "logical_port_id")]
        public string? LogicalPortId { get; set; }
        /// <summary>
        /// The Operational status of the logical port
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTRealizedLogicalPortStatusEnumType? Status { get; set; }
    }
}
