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
        public NSXTMacLearningSpecType MacLearning { get; set; }
        /// <summary>
        /// Allowing source MAC address change
        /// </summary>
        public bool? MacChangeAllowed { get; set; }
    }
}
