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
    /// Advanced load balancer DnsRuleActionGslbSiteSelection object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsRuleActionGslbSiteSelection object")]
    public class NSXTALBDnsRuleActionGslbSiteSelectionType 
    {
        /// <summary>
        /// When set to true, GSLB site is a preferred site.
        /// This setting comes into play when the site is down, as well
        /// as no configured fallback site is available (all fallback
        /// sites are also down), then any one available site is
        /// selected based on the default algorithm for GSLB pool member
        /// selection.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "is_site_preferred")]
        public bool? IsSitePreferred { get; set; }
        /// <summary>
        /// GSLB site name.
        /// </summary>
        [JsonProperty(PropertyName = "site_name", Required = Required.AllowNull)]
        public string SiteName { get; set; }
        /// <summary>
        /// GSLB fallback sites to use in case the desired site is
        /// down.
        /// Maximum of 64 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "fallback_site_names")]
        public IList<string> FallbackSiteNames { get; set; }
    }
}
