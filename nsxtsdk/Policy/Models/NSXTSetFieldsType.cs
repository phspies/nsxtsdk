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
    public class NSXTSetFieldsType : NSXTActionType
    {
        /// <summary>
        /// Field Settings.
        /// </summary>
        [JsonProperty(PropertyName = "field_settings")]
        public IList<NSXTFieldSettingType> FieldSettings { get; set; }
    }
}
