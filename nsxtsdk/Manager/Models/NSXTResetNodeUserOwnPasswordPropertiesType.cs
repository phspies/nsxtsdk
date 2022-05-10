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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTResetNodeUserOwnPasswordPropertiesType 
    {
        /// <summary>
        /// The new password for user
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// If the old_password is not given, a 400 BAD REQUEST is returned with an error message.
        /// </summary>
        [JsonProperty(PropertyName = "old_password")]
        public string? OldPassword { get; set; }
    }
}
