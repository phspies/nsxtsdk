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
    public class NSXTPolicyExtraConfigHostSwitchProfileType : NSXTPolicyBaseHostSwitchProfileType
    {
        /// <summary>
        /// list of extra configs
        /// </summary>
        [JsonProperty(PropertyName = "extra_configs")]
        public IList<NSXTPolicyExtraConfigType> ExtraConfigs { get; set; }
    }
}
