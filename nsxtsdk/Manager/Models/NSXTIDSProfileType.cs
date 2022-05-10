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
    public class NSXTIDSProfileType : NSXTManagedResourceType
    {
        /// <summary>
        /// List of IDS signatures ids which need to be detected.
        /// </summary>
        [JsonProperty(PropertyName = "signatures", Required = Required.AllowNull)]
        public IList<string> Signatures { get; set; }
    }
}
