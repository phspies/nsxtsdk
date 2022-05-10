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
    /// Additional configuration required for federation at Site.
    /// </summary>
    [NSXTProperty(Description: @"Additional configuration required for federation at Site.")]
    public class NSXTGmFederationSiteConfigType 
    {
        /// <summary>
        /// IP Addresses to be allocated for transit segment when the gateway is
        /// stretched. Note that Global Manager will carve out the IP Pool for each
        /// site to be used for edge nodes when gateway is stretched based on the
        /// user provided subnet and maximum number of edge nodes allowed per site.
        /// </summary>
        [JsonProperty(PropertyName = "transit_subnet")]
        public string? TransitSubnet { get; set; }
    }
}
