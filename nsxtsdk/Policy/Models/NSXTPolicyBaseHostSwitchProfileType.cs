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
    [JsonConverter(typeof(JsonInheritanceConverter), "resource_type")]
    [JsonInheritanceAttribute("PolicyLldpHostSwitchProfile", typeof(NSXTPolicyLldpHostSwitchProfileType))]
    [JsonInheritanceAttribute("PolicyUplinkHostSwitchProfile", typeof(NSXTPolicyUplinkHostSwitchProfileType))]
    [JsonInheritanceAttribute("PolicyNiocProfile", typeof(NSXTPolicyNiocProfileType))]
    [JsonInheritanceAttribute("PolicyExtraConfigHostSwitchProfile", typeof(NSXTPolicyExtraConfigHostSwitchProfileType))]
    [NSXTProperty(Description: @"")]
    public class NSXTPolicyBaseHostSwitchProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "required_capabilities")]
        public IList<string> RequiredCapabilities { get; set; }
        /// <summary>
        /// Supported HostSwitch profiles.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPolicyBaseHostSwitchProfileResourceTypeEnumType ResourceType { get; set; }
    }
}
