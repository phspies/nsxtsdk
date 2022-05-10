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
    public class NSXTSpoofGuardSwitchingProfileType : NSXTBaseSwitchingProfileType
    {
        /// <summary>
        /// List of providers for white listed address bindings.
        /// </summary>
        [JsonProperty(PropertyName = "white_list_providers", Required = Required.AllowNull)]
        public IList<string> WhiteListProviders { get; set; }
    }
}
