using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Relative to the form factor pre-defined reservation value. To reduce
        /// reservation of a VM to 50 percent, a user may specify 50 instead of the
        /// absolute number relevant for the edge form factor.
    /// </summary>
    [NSXTProperty(Description: @"Relative to the form factor pre-defined reservation value. To reducereservation of a VM to 50 percent, a user may specify 50 instead of theabsolute number relevant for the edge form factor.")]
    public class NSXTMemoryReservationType 
    {
        /// <summary>
        /// Memory reserved relative to the default reservation of 100 percent.
        /// For example, take an edge virtual machine of medium form factor.
        /// By default, an edge of medium form factor is configured with 8 GB of
        /// memory and with reservation of 100 percent. So, 8 GB of memory is
        /// reserved. If you specify reservation_percentage value as 50 percent,
        /// then 4 GB of memory will be reserved.
        /// </summary>
        [JsonProperty(PropertyName = "reservation_percentage")]
        public int? ReservationPercentage { get; set; }
    }
}
