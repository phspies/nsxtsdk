// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTPktcapActionConfigType 
    {
        public NSXTPktcapActionConfigType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "sampling_argument")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTSamplingArgumentType SamplingArgument { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "action_argument")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTPktcapActionArgumentType ActionArgument { get; set; }
    }
}
