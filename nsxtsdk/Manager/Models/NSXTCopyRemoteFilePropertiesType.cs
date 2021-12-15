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
    public class NSXTCopyRemoteFilePropertiesType 
    {
        /// <summary>
        /// URI of file to copy
        /// </summary>
        [JsonProperty(PropertyName = "uri", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"URI of file to copy")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Uri { get; set; }
        /// <summary>
        /// Server port
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        [NSXTProperty(IsRequired: false, Description: @"Server port")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(65535)]
        public long? Port { get; set; }
        /// <summary>
        /// Remote server hostname or IP address
        /// </summary>
        [JsonProperty(PropertyName = "server", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Remote server hostname or IP address")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Server { get; set; }
    }
}
