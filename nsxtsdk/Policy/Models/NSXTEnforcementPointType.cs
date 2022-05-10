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
    public class NSXTEnforcementPointType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "connection_info", Required = Required.AllowNull)]
        public NSXTEnforcementPointConnectionInfoType ConnectionInfo { get; set; }
        /// <summary>
        /// Version of the Enforcement point.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
        /// <summary>
        /// Auto enforce flag suggests whether the policy objects shall be automatically
        /// enforced on this enforcement point or not. When this flag is set to true,
        /// all policy objects will be automatically enforced on this enforcement
        /// point. If this flag is set to false, user shall rely on the usual means
        /// of realization, i.e., deployment maps.
        /// </summary>
        [JsonProperty(PropertyName = "auto_enforce")]
        public bool? AutoEnforce { get; set; }
    }
}
