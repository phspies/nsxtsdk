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
    public class NSXTLBUdpMonitorProfileType : NSXTLBActiveMonitorType
    {
        /// <summary>
        /// Expected data, can be anywhere in the response and it has to be a
        /// string, regular expressions are not supported.
        /// UDP healthcheck is considered failed if there is no server response
        /// within the timeout period.
        /// </summary>
        [JsonProperty(PropertyName = "receive", Required = Required.AllowNull)]
        public string Receive { get; set; }
        /// <summary>
        /// The data to be sent to the monitored server.
        /// </summary>
        [JsonProperty(PropertyName = "send", Required = Required.AllowNull)]
        public string Send { get; set; }
    }
}
