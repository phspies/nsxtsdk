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
    public class NSXTStaticRoutesType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Specify next hop routes for network.
        /// </summary>
        [JsonProperty(PropertyName = "next_hops", Required = Required.AllowNull)]
        public IList<NSXTRouterNexthopType> NextHops { get; set; }
        /// <summary>
        /// Specify network address in CIDR format.
        /// </summary>
        [JsonProperty(PropertyName = "network", Required = Required.AllowNull)]
        public string Network { get; set; }
        /// <summary>
        /// When false or by default northbound routes are configured only on the primary
        /// location and not on secondary location. When true, the static route will also be
        /// configured on a secondary location. Secondary location prefers route learned from
        /// the primary location and enabling this flag secondary location can override this.
        /// This flag is not applicable if all sites are primary.
        /// </summary>
        [JsonProperty(PropertyName = "enabled_on_secondary")]
        public bool? EnabledOnSecondary { get; set; }
    }
}
