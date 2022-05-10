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
    public class NSXTIPv6ProfilesType 
    {
        /// <summary>
        /// Identifier of Duplicate Address Detection profile.
        /// DAD profile has various configurations related to duplicate
        /// address detection. If no profile is associated manually to the router,
        /// then the system defined default DAD profile will be automatically
        /// applied.
        /// </summary>
        [JsonProperty(PropertyName = "dad_profile_id")]
        public string? DadProfileId { get; set; }
        /// <summary>
        /// Identifier of Neighbor Discovery Router Advertisement profile.
        /// NDRA profile has various configurations required for router
        /// advertisement. If no profile is associated manually to the router,
        /// then the system defined default NDRA profile will be automatically
        /// applied.
        /// </summary>
        [JsonProperty(PropertyName = "ndra_profile_id")]
        public string? NdraProfileId { get; set; }
    }
}
