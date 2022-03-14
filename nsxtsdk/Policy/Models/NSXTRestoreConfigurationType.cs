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

namespace nsxtsdk.PolicyModels
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
        public string? Passphrase { get; set; }
    }
}
