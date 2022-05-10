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
    /// Status of tag bulk operation.
    /// </summary>
    [NSXTProperty(Description: @"Status of tag bulk operation.")]
    public class NSXTTagBulkOperationStatusType 
    {
        /// <summary>
        /// Overall status
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTagBulkOperationStatusStatusEnumType Status { get; set; }
        /// <summary>
        /// Intent path corresponding to tag operation
        /// </summary>
        [JsonProperty(PropertyName = "path", Required = Required.AllowNull)]
        public string Path { get; set; }
        /// <summary>
        /// Tag apply operation status per resource type.
        /// </summary>
        [JsonProperty(PropertyName = "apply_to")]
        public IList<NSXTResourceTypeTagStatusType> ApplyTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tag", Required = Required.AllowNull)]
        public NSXTTagType Tag { get; set; }
        /// <summary>
        /// Tag remove operation status per resource type.
        /// </summary>
        [JsonProperty(PropertyName = "remove_from")]
        public IList<NSXTResourceTypeTagStatusType> RemoveFrom { get; set; }
    }
}
