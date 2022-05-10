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
    /// Details about NSX-T site.
    /// </summary>
    [NSXTProperty(Description: @"Details about NSX-T site.")]
    public class NSXTNsxtSiteType 
    {
        /// <summary>
        /// Display name for the federation site.
        /// </summary>
        [JsonProperty(PropertyName = "federation_site_display_name")]
        public string? FederationSiteDisplayName { get; set; }
        /// <summary>
        /// Federation site id.
        /// </summary>
        [JsonProperty(PropertyName = "federation_site_id")]
        public string? FederationSiteId { get; set; }
        /// <summary>
        /// IP address of NSX-T appliance at the site.
        /// </summary>
        [JsonProperty(PropertyName = "nsxt_ip")]
        public string? NsxtIp { get; set; }
        /// <summary>
        /// Type of federation site. It can be GlobalManager or Site.
        /// </summary>
        [JsonProperty(PropertyName = "federation_site_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNsxtSiteFederationSiteTypeEnumType? FederationSiteType { get; set; }
    }
}
