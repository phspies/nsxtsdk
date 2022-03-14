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
    /// Information related to OVF file.
    /// </summary>
    [NSXTProperty(Description: @"Information related to OVF file.")]
    public class NSXTOvfInfoType 
    {
        /// <summary>
        /// Version of the OVF.
        /// </summary>
        public string? Version { get; set; }
        /// <summary>
        /// Name of OVF file.
        /// </summary>
        public string? OvfName { get; set; }
    }
}
