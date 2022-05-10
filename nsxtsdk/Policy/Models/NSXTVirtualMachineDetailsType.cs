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
    public class NSXTVirtualMachineDetailsType : NSXTResourceType
    {
        /// <summary>
        /// List of active (still logged in) user login/session data (no limit).
        /// </summary>
        [JsonProperty(PropertyName = "active_sessions")]
        public IList<NSXTUserSessionType> ActiveSessions { get; set; }
        /// <summary>
        /// Optional list of up to 5 most recent archived (previously logged in) user login/session data.
        /// </summary>
        [JsonProperty(PropertyName = "archived_sessions")]
        public IList<NSXTUserSessionType> ArchivedSessions { get; set; }
    }
}
