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
    public class NSXTDuplicateAddressBindingEntryType : NSXTAddressBindingEntryType
    {
        /// <summary>
        /// Provides the ID of the port on which the same address bidning exists
        /// </summary>
        public string? ConflictingPort { get; set; }
    }
}
