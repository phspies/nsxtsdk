// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Remote file server
    /// </summary>
    [NSXTProperty(Description: @"Remote file server")]
    public class NSXTRemoteFileServerType 
    {
        /// <summary>
        /// Remote server directory to copy bundle files to
        /// </summary>
        [JsonProperty(PropertyName = "directory_path", Required = Required.AllowNull)]
        public string DirectoryPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "protocol", Required = Required.AllowNull)]
        public NSXTFileTransferProtocolType Protocol { get; set; }
        /// <summary>
        /// Server port
        /// </summary>
        public long? Port { get; set; }
        /// <summary>
        /// Remote server hostname or IP address
        /// </summary>
        [JsonProperty(PropertyName = "server", Required = Required.AllowNull)]
        public string Server { get; set; }
    }
}
