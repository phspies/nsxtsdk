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
    public class NSXTVrfL2VniConfigType 
    {
        /// <summary>
        /// L2 VNI associated with the VRF. It must be unique and available from the VNI
        /// pool defined for EVPN service.
        /// </summary>
        [JsonProperty(PropertyName = "l2_vni", Required = Required.AllowNull)]
        public int L2Vni { get; set; }
        /// <summary>
        /// Route targets.
        /// </summary>
        [JsonProperty(PropertyName = "route_targets", Required = Required.AllowNull)]
        public IList<NSXTVrfRouteTargetsType> RouteTargets { get; set; }
        /// <summary>
        /// This is a 64 bit number which disambiguates overlapping logical networks, with
        /// format in IPAddress:<number> or ASN:<number>.
        /// </summary>
        [JsonProperty(PropertyName = "route_distinguisher", Required = Required.AllowNull)]
        public string RouteDistinguisher { get; set; }
    }
}
