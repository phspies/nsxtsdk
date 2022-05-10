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
    public class NSXTFirewallSectionLockType 
    {
        /// <summary>
        /// Comments for section lock/unlock.
        /// </summary>
        [JsonProperty(PropertyName = "comments", Required = Required.AllowNull)]
        public string Comments { get; set; }
        /// <summary>
        /// Revision of the section.
        /// </summary>
        [JsonProperty(PropertyName = "section_revision", Required = Required.AllowNull)]
        public long SectionRevision { get; set; }
    }
}
