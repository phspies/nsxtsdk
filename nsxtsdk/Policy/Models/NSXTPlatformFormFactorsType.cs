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
    /// Available platform form factors.
    /// </summary>
    [NSXTProperty(Description: @"Available platform form factors.")]
    public class NSXTPlatformFormFactorsType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "available_form_factors")]
        public NSXTFormFactorsType AvailableFormFactors { get; set; }
    }
}
