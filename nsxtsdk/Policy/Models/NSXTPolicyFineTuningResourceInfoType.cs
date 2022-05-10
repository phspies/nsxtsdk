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
    /// It represent the resource with details of name and fields it owns.
    /// </summary>
    [NSXTProperty(Description: @"It represent the resource with details of name and fields it owns.")]
    public class NSXTPolicyFineTuningResourceInfoType 
    {
        /// <summary>
        /// List of all field of any resource
        /// </summary>
        [JsonProperty(PropertyName = "fields", Required = Required.AllowNull)]
        public IList<NSXTPolicyFineTuningResourceInfoDetailType> Fields { get; set; }
        /// <summary>
        /// It will represent resource with name and fields.
        /// </summary>
        [JsonProperty(PropertyName = "resource_name", Required = Required.AllowNull)]
        public string ResourceName { get; set; }
    }
}
