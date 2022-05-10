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
    public class NSXTPolicyIdsVmListType : NSXTListResultType
    {
        /// <summary>
        /// List of all affected VMs specific to a particular signature.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<string> Results { get; set; }
    }
}
