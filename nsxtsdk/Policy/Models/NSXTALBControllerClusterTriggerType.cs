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
    /// Advanced Load Balancer controller node clustering trigger response.
    /// </summary>
    [NSXTProperty(Description: @"Advanced Load Balancer controller node clustering trigger response.")]
    public class NSXTALBControllerClusterTriggerType 
    {
        /// <summary>
        /// Advanced Load Balancer controller node clustering trigger status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string? Status { get; set; }
    }
}
