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
    /// Logical port attachment
    /// </summary>
    [NSXTProperty(Description: @"Logical port attachment")]
    public class NSXTLogicalPortAttachmentType 
    {
        /// <summary>
        /// Indicates the type of logical port attachment. By default it is Virtual Machine interface (VIF)
        /// </summary>
        [JsonProperty(PropertyName = "attachment_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLogicalPortAttachmentAttachmentTypeEnumType? AttachmentType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "context")]
        public NSXTAttachmentContextType Context { get; set; }
        /// <summary>
        /// Identifier of the interface attached to the logical port
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        public string Id { get; set; }
    }
}
