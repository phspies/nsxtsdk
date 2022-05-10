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
    public class NSXTClusterControlPlaneListResultType : NSXTListResultType
    {
        /// <summary>
        /// This property include all cluster control Plane in NSX-T.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTClusterControlPlaneType> Results { get; set; }
    }
}
