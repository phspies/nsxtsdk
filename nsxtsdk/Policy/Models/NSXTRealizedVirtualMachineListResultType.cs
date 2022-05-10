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
    public class NSXTRealizedVirtualMachineListResultType : NSXTListResultType
    {
        /// <summary>
        /// Paged Collection of VMs
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTRealizedVirtualMachineType> Results { get; set; }
    }
}
