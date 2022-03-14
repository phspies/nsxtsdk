// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTExternalIDExpressionType : NSXTExpressionType
    {
        /// <summary>
        /// This array can consist of one or more external IDs for the specified member type.
        /// </summary>
        [JsonProperty(PropertyName = "external_ids", Required = Required.AllowNull)]
        public IList<string> ExternalIds { get; set; }
        /// <summary>
        /// External ID member type
        /// </summary>
        [JsonProperty(PropertyName = "member_type", Required = Required.AllowNull)]
        public NSXTExternalIdexpressionMemberTypeEnumType MemberType { get; set; }
    }
}
