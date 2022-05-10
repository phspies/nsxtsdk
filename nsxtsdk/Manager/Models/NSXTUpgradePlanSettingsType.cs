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
    public class NSXTUpgradePlanSettingsType 
    {
        /// <summary>
        /// Flag to indicate whether to pause the upgrade after upgrade of each group is completed
        /// </summary>
        [JsonProperty(PropertyName = "pause_after_each_group")]
        public bool? PauseAfterEachGroup { get; set; }
        /// <summary>
        /// Flag to indicate whether to pause the upgrade plan execution when an error occurs
        /// </summary>
        [JsonProperty(PropertyName = "pause_on_error")]
        public bool? PauseOnError { get; set; }
        /// <summary>
        /// Upgrade Method to specify whether the upgrade is to be performed serially or in parallel
        /// </summary>
        [JsonProperty(PropertyName = "parallel")]
        public bool? Parallel { get; set; }
    }
}
