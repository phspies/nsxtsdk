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
    public class NSXTManagedResourceType : NSXTRevisionedResourceType
    {
        /// <summary>
        /// Indicates system owned resource
        /// </summary>
        [JsonProperty(PropertyName = "_system_owned")]
        public bool? SystemOwned { get; set; }
        /// <summary>
        /// Defaults to ID if not set
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// Description of this resource
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Opaque identifiers meaningful to the API user
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<NSXTTagType> Tags { get; set; }
        /// <summary>
        /// ID of the user who created this resource
        /// </summary>
        [JsonProperty(PropertyName = "_create_user")]
        public string? CreateUser { get; set; }
        /// <summary>
        /// Protection status is one of the following:
        /// PROTECTED - the client who retrieved the entity is not allowed
        /// to modify it.
        /// NOT_PROTECTED - the client who retrieved the entity is allowed
        /// to modify it
        /// REQUIRE_OVERRIDE - the client who retrieved the entity is a super
        /// user and can modify it, but only when providing
        /// the request header X-Allow-Overwrite=true.
        /// UNKNOWN - the _protection field could not be determined for this
        /// entity.
        /// </summary>
        [JsonProperty(PropertyName = "_protection")]
        public string? Protection { get; set; }
        /// <summary>
        /// Timestamp of resource creation
        /// </summary>
        [JsonProperty(PropertyName = "_create_time")]
        public long? CreateTime { get; set; }
        /// <summary>
        /// Timestamp of last modification
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified_time")]
        public long? LastModifiedTime { get; set; }
        /// <summary>
        /// ID of the user who last modified this resource
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified_user")]
        public string? LastModifiedUser { get; set; }
        /// <summary>
        /// Unique identifier of this resource
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// The type of this resource.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type")]
        public string? ResourceType { get; set; }
    }
}
