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
    public class NSXTIdfwNsgroupVmDetailListResultType : NSXTListResultType
    {
        /// <summary>
        /// NSGroup ID
        /// </summary>
        [JsonProperty(PropertyName = "ns_group_id")]
        public string? NsGroupId { get; set; }
        /// <summary>
        /// List of user login/session data for a single VM
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        public IList<NSXTIdfwVmDetailType> Results { get; set; }
    }
}
