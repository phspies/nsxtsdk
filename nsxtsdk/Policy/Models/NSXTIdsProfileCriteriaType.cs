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
    /// All the filtering criteria objects extend from this abstract class.
        /// This is present for extensibility.
    /// </summary>
    [NSXTProperty(Description: @"All the filtering criteria objects extend from this abstract class.This is present for extensibility.")]
    public class NSXTIdsProfileCriteriaType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIdsProfileCriteriaResourceTypeEnumType ResourceType { get; set; }
    }
}
