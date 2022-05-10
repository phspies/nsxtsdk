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
    /// Parameter to force switch over from Standby to Active.
    /// </summary>
    [NSXTProperty(Description: @"Parameter to force switch over from Standby to Active.")]
    public class NSXTGlobalManagerSwitchOverRequestParameterType 
    {
        /// <summary>
        /// If true indicates that user requested make standby Global Manager
        /// as active ignoring the state of current active Global Manager.
        /// Typically, recommended to use when active Global Manager is failed
        /// or not reachable.
        /// </summary>
        [JsonProperty(PropertyName = "force")]
        public bool? Force { get; set; }
    }
}
