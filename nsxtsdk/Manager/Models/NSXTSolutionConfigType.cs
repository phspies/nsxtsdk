using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTSolutionConfigType : NSXTManagedResourceType
    {
        /// <summary>
        /// The service to which the solution config belongs.
        /// </summary>
        [JsonProperty(PropertyName = "service_id")]
        public string? ServiceId { get; set; }
        /// <summary>
        /// Partner needs to specify Solution Id assigned by VMware.
        /// </summary>
        [JsonProperty(PropertyName = "solution_id", Required = Required.AllowNull)]
        public string SolutionId { get; set; }
        /// <summary>
        /// Partner needs to specify their port on which their solution application which consumes NXGI EPSec library listens.
        /// </summary>
        [JsonProperty(PropertyName = "listen_port", Required = Required.AllowNull)]
        public int ListenPort { get; set; }
        /// <summary>
        /// Partner needs to specify their assigned control IP with which they have configured their OVFs.
        /// </summary>
        [JsonProperty(PropertyName = "control_ip", Required = Required.AllowNull)]
        public string ControlIp { get; set; }
    }
}
