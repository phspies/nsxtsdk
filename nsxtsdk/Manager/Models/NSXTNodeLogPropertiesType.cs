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
    public class NSXTNodeLogPropertiesType : NSXTResourceType
    {
        /// <summary>
        /// Last modified time expressed in milliseconds since epoch
        /// </summary>
        public long? LastModifiedTime { get; set; }
        /// <summary>
        /// Size of log file in bytes
        /// </summary>
        public long? LogSize { get; set; }
        /// <summary>
        /// Name of log file
        /// </summary>
        public string? LogName { get; set; }
    }
}
