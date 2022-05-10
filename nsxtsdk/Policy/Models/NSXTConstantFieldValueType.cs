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
    public class NSXTConstantFieldValueType : NSXTFieldSettingValueType
    {
        /// <summary>
        /// Constant Value that the field must be set to.
        /// </summary>
        [JsonProperty(PropertyName = "constant")]
        public object? Constant { get; set; }
    }
}
