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
    /// Details about mapping of NSX-V and NSX-T Local Manager.
    /// </summary>
    [NSXTProperty(Description: @"Details about mapping of NSX-V and NSX-T Local Manager.")]
    public class NSXTV2tSiteMappingType 
    {
        /// <summary>
        /// NSX-V API endpoint IP address
        /// </summary>
        [JsonProperty(PropertyName = "nsxv_ip")]
        public string? NsxvIp { get; set; }
        /// <summary>
        /// Federation NSX-T site id.
        /// </summary>
        [JsonProperty(PropertyName = "federation_site_id", Required = Required.AllowNull)]
        public string FederationSiteId { get; set; }
    }
}
