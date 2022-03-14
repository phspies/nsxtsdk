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
    /// An address binding entry is a combination of the IP-MAC-VLAN binding for
        /// a logical port. The address bindings can be obtained via various methods
        /// like ARP snooping, DHCP snooping etc. or by user configuration.
    /// </summary>
    [NSXTProperty(Description: @"An address binding entry is a combination of the IP-MAC-VLAN binding fora logical port. The address bindings can be obtained via various methodslike ARP snooping, DHCP snooping etc. or by user configuration.")]
    public class NSXTAddressBindingEntryType 
    {
        /// <summary>
        /// Source from which the address binding entry was obtained
        /// </summary>
        public NSXTAddressBindingEntrySourceEnumType? Source { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTPacketAddressClassifierType Binding { get; set; }
        /// <summary>
        /// Timestamp at which the binding was discovered via snooping or manually
        /// specified by the user
        /// </summary>
        public long? BindingTimestamp { get; set; }
    }
}
