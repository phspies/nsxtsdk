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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTALBWafProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// List of Data Files Used for WAF Rules.
        /// Maximum of 64 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "files")]
        public IList<NSXTALBWafDataFileType> Files { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "config", Required = Required.AllowNull)]
        public NSXTALBWafConfigType Config { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
    }
}
