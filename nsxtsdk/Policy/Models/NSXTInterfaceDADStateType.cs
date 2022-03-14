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
    /// Duplicate address detection status on the interface.
    /// </summary>
    [NSXTProperty(Description: @"Duplicate address detection status on the interface.")]
    public class NSXTInterfaceDADStateType 
    {
        /// <summary>
        /// Array of DAD status which contains DAD information for IP addresses
        /// on the interface.
        /// </summary>
        public IList<NSXTInterfaceIPv6DADStatusType> DadStatuses { get; set; }
        /// <summary>
        /// Policy path or realization ID of interface for which IPv6 DAD
        /// status is returned.
        /// </summary>
        public string? InterfacePath { get; set; }
    }
}
