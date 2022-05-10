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
    public class NSXTIdsSettingsType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Parameter to let the user decide whether to update the IDS Signatures
        /// automatically or not.
        /// </summary>
        [JsonProperty(PropertyName = "auto_update")]
        public bool? AutoUpdate { get; set; }
        /// <summary>
        /// Flag which tells whether IDS was ever enabled.
        /// </summary>
        [JsonProperty(PropertyName = "ids_ever_enabled")]
        public bool? IdsEverEnabled { get; set; }
        /// <summary>
        /// Flag to send IDS events to syslog server.
        /// </summary>
        [JsonProperty(PropertyName = "ids_events_to_syslog")]
        public bool? IdsEventsToSyslog { get; set; }
    }
}
