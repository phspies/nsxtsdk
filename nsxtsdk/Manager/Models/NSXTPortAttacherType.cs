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
    /// VM or vmknic entity attached to LogicalPort
    /// </summary>
    [NSXTProperty(Description: @"VM or vmknic entity attached to LogicalPort")]
    public class NSXTPortAttacherType 
    {
        /// <summary>
        /// TransportNode on which the attacher resides
        /// </summary>
        [JsonProperty(PropertyName = "host", Required = Required.AllowNull)]
        public string Host { get; set; }
        /// <summary>
        /// This is a vmknic name if the attacher is vmknic. Otherwise, it is
        /// full path of the attached VM's config file
        /// </summary>
        [JsonProperty(PropertyName = "entity", Required = Required.AllowNull)]
        public string Entity { get; set; }
    }
}
