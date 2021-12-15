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
        [NSXTProperty(IsRequired: true, Description: @"TransportNode on which the attacher resides")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Host { get; set; }
        /// <summary>
        /// This is a vmknic name if the attacher is vmknic. Otherwise, it is
        /// full path of the attached VM's config file
        /// </summary>
        [JsonProperty(PropertyName = "entity", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"This is a vmknic name if the attacher is vmknic. Otherwise, it isfull path of the attached VM&apos;s config file")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Entity { get; set; }
    }
}
