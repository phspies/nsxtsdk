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
    /// Route advertisement rules and filtering
    /// </summary>
    [NSXTProperty(Description: @"Route advertisement rules and filtering")]
    public class NSXTRouteAdvertisementRuleType 
    {
        /// <summary>
        /// Action to advertise filtered routes to the connected Tier0 gateway.
        /// PERMIT: Enables the advertisment
        /// DENY: Disables the advertisement
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTRouteAdvertisementRuleActionEnumType Action { get; set; }
        /// <summary>
        /// Network CIDRs to be routed.
        /// </summary>
        [JsonProperty(PropertyName = "subnets")]
        public IList<string> Subnets { get; set; }
        /// <summary>
        /// Prefix operator to filter subnets.
        /// GE prefix operator filters all the routes with prefix length greater
        /// than or equal to the subnets configured.
        /// EQ prefix operator filter all the routes with prefix length equal to
        /// the subnets configured.
        /// </summary>
        [JsonProperty(PropertyName = "prefix_operator")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTRouteAdvertisementRulePrefixOperatorEnumType? PrefixOperator { get; set; }
        /// <summary>
        /// Display name should be unique.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Enable different types of route advertisements.
        /// When not specified, routes to IPSec VPN local-endpoint subnets
        /// (TIER1_IPSEC_LOCAL_ENDPOINT) are automatically advertised.
        /// </summary>
        [JsonProperty(PropertyName = "route_advertisement_types")]
        public IList<string> RouteAdvertisementTypes { get; set; }
    }
}
