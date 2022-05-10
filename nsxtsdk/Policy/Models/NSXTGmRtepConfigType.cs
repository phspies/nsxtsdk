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
    /// Global Manager federation RTEP configuration. This configuration is distributed
        /// to all Sites participating in federation.
    /// </summary>
    [NSXTProperty(Description: @"Global Manager federation RTEP configuration. This configuration is distributedto all Sites participating in federation.")]
    public class NSXTGmRtepConfigType 
    {
        /// <summary>
        /// Password to authenticate IBGP session between remote tunnel endpoints
        /// created on federated sites. This is applied to inter-site underlay
        /// IBGP neighbors created over remote tunnel endpoints on all sites.
        /// Empty string ("") clears existing password.
        /// </summary>
        [JsonProperty(PropertyName = "ibgp_password")]
        public string? IbgpPassword { get; set; }
    }
}
