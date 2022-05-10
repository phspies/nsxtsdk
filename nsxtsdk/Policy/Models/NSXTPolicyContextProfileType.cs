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
    public class NSXTPolicyContextProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Property containing attributes/sub-attributes for Policy Context Profile.
        /// </summary>
        [JsonProperty(PropertyName = "attributes", Required = Required.AllowNull)]
        public IList<NSXTPolicyAttributesType> Attributes { get; set; }
    }
}
