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
    public class NSXTMacManagementSwitchingProfileType : NSXTBaseSwitchingProfileType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "mac_learning")]
        public NSXTMacLearningSpecType MacLearning { get; set; }
        /// <summary>
        /// Allowing source MAC address change
        /// </summary>
        [JsonProperty(PropertyName = "mac_change_allowed")]
        public bool? MacChangeAllowed { get; set; }
    }
}
