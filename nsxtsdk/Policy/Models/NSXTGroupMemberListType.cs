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
    /// List of same type members to either add or remove from a group.
    /// </summary>
    [NSXTProperty(Description: @"List of same type members to either add or remove from a group.")]
    public class NSXTGroupMemberListType 
    {
        /// <summary>
        /// This array contains group members of similar types.
        /// </summary>
        [JsonProperty(PropertyName = "members", Required = Required.AllowNull)]
        public IList<string> Members { get; set; }
    }
}
