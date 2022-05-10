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
    public class NSXTAdvanceClusterRestoreRequestType 
    {
        /// <summary>
        /// List of instructions and their associated data
        /// </summary>
        [JsonProperty(PropertyName = "data", Required = Required.AllowNull)]
        public IList<NSXTAdvanceClusterRestoreInputType> Data { get; set; }
    }
}
