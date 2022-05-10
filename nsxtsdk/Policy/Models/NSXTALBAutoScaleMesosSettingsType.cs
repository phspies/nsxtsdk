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
    /// Advanced load balancer AutoScaleMesosSettings object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer AutoScaleMesosSettings object")]
    public class NSXTALBAutoScaleMesosSettingsType 
    {
        /// <summary>
        /// Apply scaleout even when there are deployments inprogress.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "force")]
        public bool? Force { get; set; }
    }
}
