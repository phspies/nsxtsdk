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
    /// Available platform form factors.
    /// </summary>
    [NSXTProperty(Description: @"Available platform form factors.")]
    public class NSXTPlatformFormFactorsType 
    {
        public NSXTPlatformFormFactorsType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "available_form_factors")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTFormFactorsType AvailableFormFactors { get; set; }
    }
}