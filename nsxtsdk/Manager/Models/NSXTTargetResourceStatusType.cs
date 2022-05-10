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
    /// Holds status of target resource in firewall context.
    /// </summary>
    [NSXTProperty(Description: @"Holds status of target resource in firewall context.")]
    public class NSXTTargetResourceStatusType 
    {
        /// <summary>
        /// Firewall status on a target logical resource.
        /// </summary>
        [JsonProperty(PropertyName = "target_status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTargetResourceStatusTargetStatusEnumType TargetStatus { get; set; }
        /// <summary>
        /// Identifier of the NSX resource.
        /// </summary>
        [JsonProperty(PropertyName = "target_id")]
        public string? TargetId { get; set; }
    }
}
