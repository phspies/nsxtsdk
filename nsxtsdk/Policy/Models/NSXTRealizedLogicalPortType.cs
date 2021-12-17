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
    public class NSXTRealizedLogicalPortType : NSXTPolicyRealizedResourceType
    {
        public NSXTRealizedLogicalPortType()
        {
        }
        /// <summary>
        /// The id of the logical port
        /// </summary>
        [JsonProperty(PropertyName = "logical_port_id")]
        [NSXTProperty(IsRequired: false, Description: @"The id of the logical port")]
        public string? LogicalPortId { get; set; }
        /// <summary>
        /// The Operational status of the logical port
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [NSXTProperty(IsRequired: false, Description: @"The Operational status of the logical port")]
        public NSXTRealizedLogicalPortStatusEnumType? Status { get; set; }
    }
}
