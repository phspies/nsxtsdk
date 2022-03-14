// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTTnNodeAgentstatusType 
    {
        /// <summary>
        /// Show the Node Agent connected VM vif status.
        /// </summary>
        [JsonProperty(PropertyName = "hyperbus_connection_status", Required = Required.AllowNull)]
        public NSXTTnNodeAgentstatusHyperbusConnectionStatusEnumType HyperbusConnectionStatus { get; set; }
        /// <summary>
        /// Connected VM vif id.
        /// </summary>
        [JsonProperty(PropertyName = "vif_id", Required = Required.AllowNull)]
        public string VifId { get; set; }
    }
}
