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
    public class NSXTNodeUserPasswordPropertyType 
    {
        /// <summary>
        /// The new password for user
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
    }
}
