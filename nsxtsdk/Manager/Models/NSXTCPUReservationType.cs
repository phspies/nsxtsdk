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
    /// Relative to the form factor pre-defined reservation value. We recommended
        /// that you use the predefined measures of CPU reservation shares to reduce
        /// the CPU reservation of a VM. Reservation shares are relative to the
        /// default form-factor value. Though absolute values for CPU reservation
        /// is supported, we advise to use this option with caution as incorrect or
        /// high reservation values could lead to deployment failure or lead to
        /// resource starvation for other VMs running on the same host.
    /// </summary>
    [NSXTProperty(Description: @"Relative to the form factor pre-defined reservation value. We recommendedthat you use the predefined measures of CPU reservation shares to reducethe CPU reservation of a VM. Reservation shares are relative to thedefault form-factor value. Though absolute values for CPU reservationis supported, we advise to use this option with caution as incorrect orhigh reservation values could lead to deployment failure or lead toresource starvation for other VMs running on the same host.")]
    public class NSXTCPUReservationType 
    {
        /// <summary>
        /// The CPU reservation in MHz is the guaranteed minimum amount of clock
        /// cycles that the vmkernel CPU scheduler will give the Edge VM in case
        /// of contention. If an Edge VM is not using its reserved resources, then
        /// other machines can use them thus preventing waste of CPU cycles on the
        /// physical host. Note: We recommend use of reservation_in_shares instead
        /// of this absolute configuration. When you specify this value, set
        /// reservation_in_shares to LOW_PRIORITY.
        /// </summary>
        [JsonProperty(PropertyName = "reservation_in_mhz")]
        public int? ReservationInMhz { get; set; }
        /// <summary>
        /// Shares specify the relative importance of a virtual machine on a given
        /// host. When you assign shares to a virtual machine, you always specify
        /// the priority for that virtual machine relative to other powered-on
        /// virtual machines on the same host. The default priority for shares is
        /// HIGH_PRIORITY.
        /// </summary>
        [JsonProperty(PropertyName = "reservation_in_shares")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTCpureservationReservationInSharesEnumType? ReservationInShares { get; set; }
    }
}
