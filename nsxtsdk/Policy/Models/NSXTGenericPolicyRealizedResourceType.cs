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
    public class NSXTGenericPolicyRealizedResourceType : NSXTPolicyRealizedResourceType
    {
        /// <summary>
        /// The site where this entity resides.
        /// </summary>
        public string? SitePath { get; set; }
        /// <summary>
        /// Collection of intent paths
        /// </summary>
        public IList<string> IntentPaths { get; set; }
        /// <summary>
        /// The path of the enforcement point.
        /// </summary>
        public string? EnforcementPointPath { get; set; }
        /// <summary>
        /// Collection of type specific properties
        /// </summary>
        public IList<NSXTAttributeValType> ExtendedAttributes { get; set; }
        /// <summary>
        /// Type of realized entity
        /// </summary>
        public string? EntityType { get; set; }
    }
}
