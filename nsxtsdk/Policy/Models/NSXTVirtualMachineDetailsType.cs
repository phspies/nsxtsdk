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
    public class NSXTVirtualMachineDetailsType : NSXTResourceType
    {
        public NSXTVirtualMachineDetailsType()
        {
        }
        /// <summary>
        /// List of active (still logged in) user login/session data (no limit).
        /// </summary>
        [JsonProperty(PropertyName = "active_sessions")]
        [NSXTProperty(IsRequired: false, Description: @"List of active (still logged in) user login/session data (no limit).")]
        public IList<NSXTUserSessionType> ActiveSessions { get; set; }
        /// <summary>
        /// Optional list of up to 5 most recent archived (previously logged in) user login/session data.
        /// </summary>
        [JsonProperty(PropertyName = "archived_sessions")]
        [NSXTProperty(IsRequired: false, Description: @"Optional list of up to 5 most recent archived (previously logged in) user login/session data.")]
        public IList<NSXTUserSessionType> ArchivedSessions { get; set; }
    }
}
