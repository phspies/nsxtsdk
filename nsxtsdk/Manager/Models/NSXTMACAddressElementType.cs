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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTMACAddressElementType : NSXTRevisionedResourceType
    {
        /// <summary>
        /// A MAC address. Must be 6 pairs of hexadecimal digits, upper or lower case,
        /// separated by colons or dashes. Examples: 01:23:45:67:89:ab, 01-23-45-67-89-AB.
        /// </summary>
        [JsonProperty(PropertyName = "mac_address", Required = Required.AllowNull)]
        public string MacAddress { get; set; }
    }
}
