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
    /// Different form factor for deployment.
    /// </summary>
    [NSXTProperty(Description: @"Different form factor for deployment.")]
    public class NSXTFormFactorsType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "evaluation")]
        public NSXTFormFactorDetailType Evaluation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "advanced")]
        public NSXTFormFactorDetailType Advanced { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "standard")]
        public NSXTFormFactorDetailType Standard { get; set; }
    }
}
