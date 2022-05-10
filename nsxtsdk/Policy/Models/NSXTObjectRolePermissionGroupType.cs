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
    public class NSXTObjectRolePermissionGroupType : NSXTManagedResourceType
    {
        /// <summary>
        /// Allowed operation
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTObjectRolePermissionGroupOperationEnumType? Operation { get; set; }
        /// <summary>
        /// Role name
        /// </summary>
        [JsonProperty(PropertyName = "role_name", Required = Required.AllowNull)]
        public string RoleName { get; set; }
        /// <summary>
        /// Is rule disabled or not
        /// </summary>
        [JsonProperty(PropertyName = "rule_disabled")]
        public bool? RuleDisabled { get; set; }
        /// <summary>
        /// Does children of this object inherit this rule
        /// </summary>
        [JsonProperty(PropertyName = "inheritance_disabled")]
        public bool? InheritanceDisabled { get; set; }
        /// <summary>
        /// Path prefix
        /// </summary>
        [JsonProperty(PropertyName = "path_prefix", Required = Required.AllowNull)]
        public string PathPrefix { get; set; }
    }
}
