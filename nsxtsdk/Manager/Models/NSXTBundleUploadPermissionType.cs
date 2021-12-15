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
    /// Describes wether bundle upload is allowed or not
    /// </summary>
    [NSXTProperty(Description: @"Describes wether bundle upload is allowed or not")]
    public class NSXTBundleUploadPermissionType 
    {
        /// <summary>
        /// Reason for not allowing upload
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        [NSXTProperty(IsRequired: false, Description: @"Reason for not allowing upload")]
        public string? Reason { get; set; }
        /// <summary>
        /// Flag indecation whether upload is allowed or not
        /// </summary>
        [JsonProperty(PropertyName = "upload_allowed")]
        [NSXTProperty(IsRequired: false, Description: @"Flag indecation whether upload is allowed or not")]
        public bool? UploadAllowed { get; set; }
    }
}
