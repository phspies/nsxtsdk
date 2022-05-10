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
    /// Vrf Route Targets for import/export.
    /// </summary>
    [NSXTProperty(Description: @"Vrf Route Targets for import/export.")]
    public class NSXTVrfRouteTargetsType 
    {
        /// <summary>
        /// Address family.
        /// </summary>
        [JsonProperty(PropertyName = "address_family")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTVrfRouteTargetsAddressFamilyEnumType? AddressFamily { get; set; }
        /// <summary>
        /// Import route targets with format in ASN:<number>.
        /// </summary>
        [JsonProperty(PropertyName = "import_route_targets")]
        public IList<string> ImportRouteTargets { get; set; }
        /// <summary>
        /// Export route targets with format in ASN:<number>.
        /// </summary>
        [JsonProperty(PropertyName = "export_route_targets")]
        public IList<string> ExportRouteTargets { get; set; }
    }
}
