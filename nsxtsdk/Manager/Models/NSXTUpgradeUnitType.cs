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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTUpgradeUnitType : NSXTResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        public NSXTUpgradeUnitGroupInfoType Group { get; set; }
        /// <summary>
        /// List of warnings indicating issues with the upgrade unit that may result in upgrade failure
        /// </summary>
        public IList<string> Warnings { get; set; }
        /// <summary>
        /// This is component version e.g. if upgrade unit is of type edge, then this is edge version.
        /// </summary>
        public string? CurrentVersion { get; set; }
        /// <summary>
        /// Metadata about upgrade unit
        /// </summary>
        public IList<NSXTKeyValuePairType> Metadata { get; set; }
        /// <summary>
        /// Upgrade unit type
        /// </summary>
        public string? Type { get; set; }
        /// <summary>
        /// Identifier of the upgrade unit
        /// </summary>
        public string? Id { get; set; }
        /// <summary>
        /// Name of the upgrade unit
        /// </summary>
        public string? DisplayName { get; set; }
    }
}
