using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// NS Attributes data holder structure
    /// </summary>
    [NSXTProperty(Description: @"NS Attributes data holder structure")]
    public class NSXTNSAttributesType 
    {
        /// <summary>
        /// Reference to sub attributes for the attribute
        /// </summary>
        [JsonProperty(PropertyName = "sub_attributes")]
        public IList<NSXTNSAttributesDataType> SubAttributes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "attributes_data", Required = Required.AllowNull)]
        public NSXTNSAttributesDataType AttributesData { get; set; }
    }
}
