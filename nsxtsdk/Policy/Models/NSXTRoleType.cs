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
    /// Role
    /// </summary>
    [NSXTProperty(Description: @"Role")]
    public class NSXTRoleType 
    {
        /// <summary>
        /// Short identifier for the role. Must be all lower case with no spaces.
        /// </summary>
        [JsonProperty(PropertyName = "role", Required = Required.AllowNull)]
        public string Role { get; set; }
        /// <summary>
        /// A short, human-friendly display name of the role.
        /// </summary>
        [JsonProperty(PropertyName = "role_display_name")]
        public string? RoleDisplayName { get; set; }
    }
}
