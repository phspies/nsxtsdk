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
    /// Contains the details of resource field
    /// </summary>
    [NSXTProperty(Description: @"Contains the details of resource field")]
    public class NSXTPolicyFineTuningResourceInfoDetailType 
    {
        /// <summary>
        /// It will represent resource with name and fields.
        /// </summary>
        [JsonProperty(PropertyName = "field_name", Required = Required.AllowNull)]
        public string FieldName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "sub_type", Required = Required.AllowNull)]
        public NSXTPolicyFineTuningResourceInfoType SubType { get; set; }
    }
}
