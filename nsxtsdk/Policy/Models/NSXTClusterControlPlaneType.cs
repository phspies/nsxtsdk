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
    public class NSXTClusterControlPlaneType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// This property is used to identify the cluster control plane in NSX-T.
        /// This id should assigned by NSX-T in create process.
        /// </summary>
        [JsonProperty(PropertyName = "node_id")]
        public string? NodeId { get; set; }
        /// <summary>
        /// This property should be afford in create process for VHC module
        /// requirement.
        /// </summary>
        [JsonProperty(PropertyName = "vhc_path")]
        public string? VhcPath { get; set; }
        /// <summary>
        /// This property should be afford in create process.
        /// </summary>
        [JsonProperty(PropertyName = "certificate")]
        public string? Certificate { get; set; }
    }
}
