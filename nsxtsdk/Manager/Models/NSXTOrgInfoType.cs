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
    /// Organization ID and role, predefined for a particular type of VMware support.
    /// </summary>
    [NSXTProperty(Description: @"Organization ID and role, predefined for a particular type of VMware support.")]
    public class NSXTOrgInfoType 
    {
        /// <summary>
        /// Organization ID, connected to a predefined role of a VMware support.
        /// </summary>
        [JsonProperty(PropertyName = "org_id", Required = Required.AllowNull)]
        public string OrgId { get; set; }
        /// <summary>
        /// Predefined role of a VMware support.
        /// </summary>
        [JsonProperty(PropertyName = "org_role", Required = Required.AllowNull)]
        public string OrgRole { get; set; }
    }
}
