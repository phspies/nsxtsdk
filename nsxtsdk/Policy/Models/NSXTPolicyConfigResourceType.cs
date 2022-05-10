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
    public class NSXTPolicyConfigResourceType : NSXTPolicyResourceType
    {
        /// <summary>
        /// subtree for this type within policy tree containing nested elements.
        /// </summary>
        [JsonProperty(PropertyName = "children")]
        public IList<NSXTChildPolicyConfigResourceType> Children { get; set; }
        /// <summary>
        /// Global intent objects cannot be modified by the user.
        /// However, certain global intent objects can be overridden locally by use
        /// of this property. In such cases, the overridden local values take
        /// precedence over the globally defined values for the properties.
        /// </summary>
        [JsonProperty(PropertyName = "overridden")]
        public bool? Overridden { get; set; }
        /// <summary>
        /// Intent objects are not directly deleted from the system when a delete
        /// is invoked on them. They are marked for deletion and only when all the
        /// realized entities for that intent object gets deleted, the intent object
        /// is deleted. Objects that are marked for deletion are not returned in
        /// GET call. One can use the search API to get these objects.
        /// </summary>
        [JsonProperty(PropertyName = "marked_for_delete")]
        public bool? MarkedForDelete { get; set; }
    }
}
