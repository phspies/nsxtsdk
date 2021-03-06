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
    /// Reaction Action is the action to take when the stipulated criteria specified
        /// in the event exist over the source. Some example actions include:
        /// - Notify Admin (or VMC's SRE) via email.
        /// - Populate a specific label with the IPSec VPN Session.
        /// - Remove the IPSec VPN Session from a specific label.
    /// </summary>
    [NSXTProperty(Description: @"Reaction Action is the action to take when the stipulated criteria specifiedin the event exist over the source. Some example actions include:- Notify Admin (or VMC&apos;s SRE) via email.- Populate a specific label with the IPSec VPN Session.- Remove the IPSec VPN Session from a specific label.")]
    public class NSXTActionType 
    {
        /// <summary>
        /// Reaction Action resource type.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTActionResourceTypeEnumType ResourceType { get; set; }
    }
}
