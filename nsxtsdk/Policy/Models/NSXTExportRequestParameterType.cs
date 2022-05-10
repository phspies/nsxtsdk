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
    /// This holds the request parameters required to invoke export task.
    /// </summary>
    [NSXTProperty(Description: @"This holds the request parameters required to invoke export task.")]
    public class NSXTExportRequestParameterType 
    {
        /// <summary>
        /// Policy path of a draft which is to be exported.
        /// If not provided, current firewall configuration will then be exported.
        /// </summary>
        [JsonProperty(PropertyName = "draft_path")]
        public string? DraftPath { get; set; }
        /// <summary>
        /// Passphrase to sign exported files.
        /// The passphrase specified must be at least 8 characters in length and
        /// must contain at least one lowercase, one uppercase, one numeric
        /// character and one non-space special character.
        /// </summary>
        [JsonProperty(PropertyName = "passphrase")]
        public string? Passphrase { get; set; }
    }
}
