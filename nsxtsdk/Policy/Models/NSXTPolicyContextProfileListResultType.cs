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
    public class NSXTPolicyContextProfileListResultType : NSXTListResultType
    {
        /// <summary>
        /// Paged collection of PolicyContextProfiles
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTPolicyContextProfileType> Results { get; set; }
    }
}
