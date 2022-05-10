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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTTnNodeAgentstatusType 
    {
        /// <summary>
        /// Show the Node Agent connected VM vif status.
        /// </summary>
        [JsonProperty(PropertyName = "hyperbus_connection_status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTnNodeAgentstatusHyperbusConnectionStatusEnumType HyperbusConnectionStatus { get; set; }
        /// <summary>
        /// Connected VM vif id.
        /// </summary>
        [JsonProperty(PropertyName = "vif_id", Required = Required.AllowNull)]
        public string VifId { get; set; }
    }
}
