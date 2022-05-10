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
    /// Advanced load balancer HealthMonitorExternal object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HealthMonitorExternal object")]
    public class NSXTALBHealthMonitorExternalType 
    {
        /// <summary>
        /// Command script provided inline.
        /// </summary>
        [JsonProperty(PropertyName = "command_code", Required = Required.AllowNull)]
        public string CommandCode { get; set; }
        /// <summary>
        /// Environment variables to be fed into the script.
        /// </summary>
        [JsonProperty(PropertyName = "command_variables")]
        public string? CommandVariables { get; set; }
        /// <summary>
        /// Optional arguments to feed into the script.
        /// </summary>
        [JsonProperty(PropertyName = "command_parameters")]
        public string? CommandParameters { get; set; }
        /// <summary>
        /// Path of external health monitor script.
        /// </summary>
        [JsonProperty(PropertyName = "command_path")]
        public string? CommandPath { get; set; }
    }
}
