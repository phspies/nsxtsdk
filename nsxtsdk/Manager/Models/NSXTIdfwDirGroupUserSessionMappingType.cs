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
    /// Identity Firewall NSGorup to user mapping to link DirGroup to user session data.
    /// </summary>
    [NSXTProperty(Description: @"Identity Firewall NSGorup to user mapping to link DirGroup to user session data.")]
    public class NSXTIdfwDirGroupUserSessionMappingType 
    {
        /// <summary>
        /// User ID.
        /// </summary>
        [JsonProperty(PropertyName = "user_id")]
        public string? UserId { get; set; }
        /// <summary>
        /// Directory Group ID.
        /// </summary>
        [JsonProperty(PropertyName = "dir_group_id")]
        public string? DirGroupId { get; set; }
    }
}
