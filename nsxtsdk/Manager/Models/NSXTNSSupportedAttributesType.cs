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
    /// Supported attributes and sub-attributes for NSProfile
    /// </summary>
    [NSXTProperty(Description: @"Supported attributes and sub-attributes for NSProfile")]
    public class NSXTNSSupportedAttributesType 
    {
        /// <summary>
        /// The type represent pre-defined or user defined list of supported attributes
        /// and sub-attributes that can be used while creating NSProfile
        /// </summary>
        [JsonProperty(PropertyName = "ns_attributes", Required = Required.AllowNull)]
        public IList<NSXTNSAttributesType> NsAttributes { get; set; }
    }
}
