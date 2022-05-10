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
    /// Details about mapping of NSX-T site to AVI LB endpoint.
    /// </summary>
    [NSXTProperty(Description: @"Details about mapping of NSX-T site to AVI LB endpoint.")]
    public class NSXTNsxtSiteToAviMappingType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "avi_lb_endpoint")]
        public NSXTAviEndPointType AviLbEndpoint { get; set; }
        /// <summary>
        /// Federation NSX-T site id.
        /// </summary>
        [JsonProperty(PropertyName = "federation_site_id")]
        public string? FederationSiteId { get; set; }
    }
}
