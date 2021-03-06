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
    public class NSXTFileThumbprintType : NSXTResourceType
    {
        /// <summary>
        /// File's SHA256 thumbprint
        /// </summary>
        [JsonProperty(PropertyName = "sha256", Required = Required.AllowNull)]
        public string Sha256 { get; set; }
        /// <summary>
        /// File name
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// File's SHA1 thumbprint
        /// </summary>
        [JsonProperty(PropertyName = "sha1", Required = Required.AllowNull)]
        public string Sha1 { get; set; }
    }
}
