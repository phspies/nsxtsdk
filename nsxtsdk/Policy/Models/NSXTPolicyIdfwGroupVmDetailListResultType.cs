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
    public class NSXTPolicyIdfwGroupVmDetailListResultType : NSXTListResultType
    {
        /// <summary>
        /// String Path of the group
        /// </summary>
        [JsonProperty(PropertyName = "group_path")]
        public string? GroupPath { get; set; }
        /// <summary>
        /// List of user login/session data for a single VM
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTIdfwVmDetailType> Results { get; set; }
    }
}
