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
    public class NSXTVersionListType : NSXTManagedResourceType
    {
        /// <summary>
        /// List of component versions
        /// </summary>
        [JsonProperty(PropertyName = "acceptable_versions", Required = Required.AllowNull)]
        public IList<string> AcceptableVersions { get; set; }
    }
}
