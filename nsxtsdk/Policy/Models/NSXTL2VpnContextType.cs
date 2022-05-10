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
    public class NSXTL2VpnContextType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// If enabled, the tier-0 acts as a Hub and replicates traffic received from
        /// peer to all other peers. If disabled, the tier-0 acts as a Spoke and
        /// replicates only the local.
        /// </summary>
        [JsonProperty(PropertyName = "enable_hub")]
        public bool? EnableHub { get; set; }
    }
}
