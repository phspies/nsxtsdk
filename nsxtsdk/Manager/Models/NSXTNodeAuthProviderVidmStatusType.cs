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
    /// Node AAA provider vIDM status
    /// </summary>
    [NSXTProperty(Description: @"Node AAA provider vIDM status")]
    public class NSXTNodeAuthProviderVidmStatusType 
    {
        /// <summary>
        /// AAA provider vIDM status
        /// </summary>
        [JsonProperty(PropertyName = "runtime_state", Required = Required.AllowNull)]
        public string RuntimeState { get; set; }
        /// <summary>
        /// vIDM enable flag
        /// </summary>
        [JsonProperty(PropertyName = "vidm_enable", Required = Required.AllowNull)]
        public bool VidmEnable { get; set; }
    }
}
