// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

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
        [NSXTProperty(IsRequired: true, Description: @"File&apos;s SHA256 thumbprint")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Sha256 { get; set; }
        /// <summary>
        /// File name
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"File name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// File's SHA1 thumbprint
        /// </summary>
        [JsonProperty(PropertyName = "sha1", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"File&apos;s SHA1 thumbprint")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Sha1 { get; set; }
    }
}