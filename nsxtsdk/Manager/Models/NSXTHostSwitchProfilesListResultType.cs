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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTHostSwitchProfilesListResultType : NSXTListResultType
    {
        public NSXTHostSwitchProfilesListResultType()
        {
        }
        /// <summary>
        /// HostSwitch Profile Results
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        [NSXTProperty(IsRequired: false, Description: @"HostSwitch Profile Results")]
        public IList<NSXTBaseHostSwitchProfileType> Results { get; set; }
    }
}
