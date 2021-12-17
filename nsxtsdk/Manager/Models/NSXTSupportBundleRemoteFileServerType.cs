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
    /// Remote file server
    /// </summary>
    [NSXTProperty(Description: @"Remote file server")]
    public class NSXTSupportBundleRemoteFileServerType 
    {
        public NSXTSupportBundleRemoteFileServerType()
        {
            Port = test
        }
        /// <summary>
        /// Uploads to the remote file server performed by the manager
        /// </summary>
        [JsonProperty(PropertyName = "manager_upload_only")]
        [NSXTProperty(IsRequired: false, Description: @"Uploads to the remote file server performed by the manager")]
        public bool? ManagerUploadOnly { get; set; }
        /// <summary>
        /// Remote server directory to copy bundle files to
        /// </summary>
        [JsonProperty(PropertyName = "directory_path", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Remote server directory to copy bundle files to")]
        [System.ComponentModel.DataAnnotations.Required]
        public string DirectoryPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "protocol", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTSupportBundleFileTransferProtocolType Protocol { get; set; }
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
