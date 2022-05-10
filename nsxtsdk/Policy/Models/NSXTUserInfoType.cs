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
    /// Authenticated User Info
    /// </summary>
    [NSXTProperty(Description: @"Authenticated User Info")]
    public class NSXTUserInfoType 
    {
        /// <summary>
        /// User Name
        /// </summary>
        [JsonProperty(PropertyName = "user_name")]
        public string? UserName { get; set; }
        /// <summary>
        /// Permissions
        /// </summary>
        [JsonProperty(PropertyName = "roles")]
        public IList<NSXTNsxRoleType> Roles { get; set; }
    }
}
