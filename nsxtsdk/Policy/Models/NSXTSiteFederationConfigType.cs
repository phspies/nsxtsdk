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
    /// Site fedeation configuration.
    /// </summary>
    [NSXTProperty(Description: @"Site fedeation configuration.")]
    public class NSXTSiteFederationConfigType 
    {
        /// <summary>
        /// Site path
        /// </summary>
        [JsonProperty(PropertyName = "site_path")]
        public string? SitePath { get; set; }
        /// <summary>
        /// Unique site index allocated (from range 0-4095)
        /// </summary>
        [JsonProperty(PropertyName = "site_index")]
        public long? SiteIndex { get; set; }
        /// <summary>
        /// Site UUID
        /// </summary>
        [JsonProperty(PropertyName = "site_id")]
        public string? SiteId { get; set; }
        /// <summary>
        /// Remote tunnel endpoint IP addresses
        /// </summary>
        [JsonProperty(PropertyName = "rtep_ips")]
        public IList<string> RtepIps { get; set; }
    }
}
