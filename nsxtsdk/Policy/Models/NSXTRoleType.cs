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
    /// Role
    /// </summary>
    [NSXTProperty(Description: @"Role")]
    public class NSXTRoleType 
    {
        public NSXTRoleType()
        {
        }
        /// <summary>
        /// Short identifier for the role. Must be all lower case with no spaces.
        /// </summary>
        [JsonProperty(PropertyName = "role", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Short identifier for the role. Must be all lower case with no spaces.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Role { get; set; }
        /// <summary>
        /// A short, human-friendly display name of the role.
        /// </summary>
        [JsonProperty(PropertyName = "role_display_name")]
        [NSXTProperty(IsRequired: false, Description: @"A short, human-friendly display name of the role.")]
        public string? RoleDisplayName { get; set; }
    }
}
