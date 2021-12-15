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
    public class NSXTDirectoryAdGroupType : NSXTDirectoryGroupType
    {
        /// <summary>
        /// GUID is a 128-bit value that is unique not only in the enterprise but also across the world. GUIDs are assigned to every
        /// object created by Active Directory, not just User and Group objects.
        /// </summary>
        [JsonProperty(PropertyName = "object_guid", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"GUID is a 128-bit value that is unique not only in the enterprise but also across the world. GUIDs are assigned to every object created by Active Directory, not just User and Group objects.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ObjectGuid { get; set; }
        /// <summary>
        /// A security identifier (SID) is a unique value of variable length used to identify a trustee. A SID consists of the
        /// following components - The revision level of the SID structure; A 48-bit identifier authority value that identifies the
        /// authority that issued the SID; A variable number of subauthority or relative identifier (RID) values that uniquely
        /// identify the trustee relative to the authority that issued the SID.
        /// </summary>
        [JsonProperty(PropertyName = "secure_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"A security identifier (SID) is a unique value of variable length used to identify a trustee. A SID consists of the following components - The revision level of the SID structure; A 48-bit identifier authority value that identifies the authority that issued the SID; A variable number of subauthority or relative identifier (RID) values that uniquely identify the trustee relative to the authority that issued the SID.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string SecureId { get; set; }
    }
}
