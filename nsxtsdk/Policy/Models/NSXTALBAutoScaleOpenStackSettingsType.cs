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
    /// Advanced load balancer AutoScaleOpenStackSettings object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer AutoScaleOpenStackSettings object")]
    public class NSXTALBAutoScaleOpenStackSettingsType 
    {
        /// <summary>
        /// Avi Controller will use this URL to scale upthe pool.
        /// Cloud connector will automatically update the membership.
        /// This is an alpha feature.
        /// </summary>
        [JsonProperty(PropertyName = "heat_scale_up_url")]
        public string? HeatScaleUpUrl { get; set; }
        /// <summary>
        /// Avi Controller will use this URL to scale downthe pool.
        /// Cloud connector will automatically update the membership.
        /// This is an alpha feature.
        /// </summary>
        [JsonProperty(PropertyName = "heat_scale_down_url")]
        public string? HeatScaleDownUrl { get; set; }
    }
}
