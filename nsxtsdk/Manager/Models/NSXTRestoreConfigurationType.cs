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
    /// Configuration where backup files are stored for restore
    /// </summary>
    [NSXTProperty(Description: @"Configuration where backup files are stored for restore")]
    public class NSXTRestoreConfigurationType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "remote_file_server", Required = Required.AllowNull)]
        public NSXTRemoteFileServerType RemoteFileServer { get; set; }
        /// <summary>
        /// Passphrase used to encrypt backup files.
        /// </summary>
        [JsonProperty(PropertyName = "passphrase")]
        public string? Passphrase { get; set; }
    }
}
