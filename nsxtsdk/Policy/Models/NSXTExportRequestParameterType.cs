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
        [NSXTProperty(IsRequired: false, Description: @"Policy path of a draft which is to be exported.If not provided, current firewall configuration will then be exported.")]
        public string? DraftPath { get; set; }
        /// <summary>
        /// Passphrase to sign exported files.
        /// The passphrase specified must be at least 8 characters in length and
        /// must contain at least one lowercase, one uppercase, one numeric
        /// character and one non-space special character.
        /// </summary>
        [JsonProperty(PropertyName = "passphrase")]
        [NSXTProperty(IsRequired: false, Description: @"Passphrase to sign exported files.The passphrase specified must be at least 8 characters in length andmust contain at least one lowercase, one uppercase, one numericcharacter and one non-space special character.")]
        public string? Passphrase { get; set; }
    }
}
