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
    /// Port Connection Bare Metal Entities
    /// </summary>
    [NSXTProperty(Description: @"Port Connection Bare Metal Entities")]
    public class NSXTPortConnectionBMEntitiesType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "src_port")]
        public NSXTLogicalPortType SrcPort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "dst_port")]
        public NSXTLogicalPortType DstPort { get; set; }
    }
}
