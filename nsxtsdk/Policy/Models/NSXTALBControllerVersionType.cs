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
    /// ALB Controller Version
    /// </summary>
    [NSXTProperty(Description: @"ALB Controller Version")]
    public class NSXTALBControllerVersionType 
    {
        /// <summary>
        /// It is ALB Controller version deployed by NSX-ALB.
        /// </summary>
        [JsonProperty(PropertyName = "alb_controller_version")]
        public string? AlbControllerVersion { get; set; }
        /// <summary>
        /// It is ALB API version supported by NSX-ALB.
        /// </summary>
        [JsonProperty(PropertyName = "alb_api_version")]
        public string? AlbApiVersion { get; set; }
    }
}
