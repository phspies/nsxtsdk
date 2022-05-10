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
    public class NSXTIdentityGroupExpressionType : NSXTExpressionType
    {
        /// <summary>
        /// This array consists of set of identity group object. All members within this array are implicitly OR'ed together.
        /// </summary>
        [JsonProperty(PropertyName = "identity_groups", Required = Required.AllowNull)]
        public IList<NSXTIdentityGroupInfoType> IdentityGroups { get; set; }
    }
}
