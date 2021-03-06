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
    /// Organization Unit
    /// </summary>
    [NSXTProperty(Description: @"Organization Unit")]
    public class NSXTDirectoryOrgUnitType 
    {
        /// <summary>
        /// Distinguished name of the organization unit.
        /// </summary>
        [JsonProperty(PropertyName = "distinguished_name", Required = Required.AllowNull)]
        public string DistinguishedName { get; set; }
        /// <summary>
        /// Organization Unit name.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// List of children Organization Units if any.
        /// </summary>
        [JsonProperty(PropertyName = "children", Required = Required.AllowNull)]
        public IList<NSXTDirectoryOrgUnitType> Children { get; set; }
    }
}
