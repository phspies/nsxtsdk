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
    public class NSXTExtraConfigHostSwitchProfileType : NSXTBaseHostSwitchProfileType
    {
        /// <summary>
        /// list of extra configs
        /// </summary>
        [JsonProperty(PropertyName = "extra_configs")]
        public IList<NSXTExtraConfigType> ExtraConfigs { get; set; }
    }
}
