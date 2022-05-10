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
    /// IPSec VPN tunnel traffic statistics.
    /// </summary>
    [NSXTProperty(Description: @"IPSec VPN tunnel traffic statistics.")]
    public class NSXTIpSecVpnTunnelTrafficStatisticsType 
    {
        /// <summary>
        /// Total number of packets dropped while sending for any reason.
        /// </summary>
        [JsonProperty(PropertyName = "packets_sent_other_error")]
        public long? PacketsSentOtherError { get; set; }
        /// <summary>
        /// Total number of outgoing packets on outbound Security association.
        /// </summary>
        [JsonProperty(PropertyName = "packets_out")]
        public long? PacketsOut { get; set; }
        /// <summary>
        /// Total number of outgoing packets dropped on outbound security association.
        /// </summary>
        [JsonProperty(PropertyName = "dropped_packets_out")]
        public long? DroppedPacketsOut { get; set; }
        /// <summary>
        /// Total number of packets dropped due to integrity failures.
        /// </summary>
        [JsonProperty(PropertyName = "integrity_failures")]
        public long? IntegrityFailures { get; set; }
        /// <summary>
        /// Number of packets dropped because of no matching policy is available.
        /// </summary>
        [JsonProperty(PropertyName = "nomatching_policy_errors")]
        public long? NomatchingPolicyErrors { get; set; }
        /// <summary>
        /// Totoal number of security association mismatch errors on incoming packets.
        /// </summary>
        [JsonProperty(PropertyName = "sa_mismatch_errors_in")]
        public long? SaMismatchErrorsIn { get; set; }
        /// <summary>
        /// Tunnel peer subnet in IPv4 CIDR Block format.
        /// </summary>
        [JsonProperty(PropertyName = "peer_subnet")]
        public string? PeerSubnet { get; set; }
        /// <summary>
        /// Total number of packets dropped due to replay check on that Security association.
        /// </summary>
        [JsonProperty(PropertyName = "replay_errors")]
        public long? ReplayErrors { get; set; }
        /// <summary>
        /// Total number of outgoing bytes on outbound Security association.
        /// </summary>
        [JsonProperty(PropertyName = "bytes_out")]
        public long? BytesOut { get; set; }
        /// <summary>
        /// Total number of incoming packets dropped on inbound Security association.
        /// </summary>
        [JsonProperty(PropertyName = "packets_received_other_error")]
        public long? PacketsReceivedOtherError { get; set; }
        /// <summary>
        /// Total number of incoming packets dropped on inbound security association.
        /// </summary>
        [JsonProperty(PropertyName = "dropped_packets_in")]
        public long? DroppedPacketsIn { get; set; }
        /// <summary>
        /// Total number of packets dropped because of failure in encryption.
        /// </summary>
        [JsonProperty(PropertyName = "encryption_failures")]
        public long? EncryptionFailures { get; set; }
        /// <summary>
        /// Totoal number of security association mismatch errors on outgoing packets.
        /// </summary>
        [JsonProperty(PropertyName = "sa_mismatch_errors_out")]
        public long? SaMismatchErrorsOut { get; set; }
        /// <summary>
        /// Gives the detailed reason about the tunnel when it is down. If tunnel
        /// is UP tunnel down reason will be empty.
        /// </summary>
        [JsonProperty(PropertyName = "tunnel_down_reason")]
        public string? TunnelDownReason { get; set; }
        /// <summary>
        /// Tunnel local subnet in IPv4 CIDR Block format.
        /// </summary>
        [JsonProperty(PropertyName = "local_subnet")]
        public string? LocalSubnet { get; set; }
        /// <summary>
        /// Total number of incoming bytes on inbound Security association.
        /// </summary>
        [JsonProperty(PropertyName = "bytes_in")]
        public long? BytesIn { get; set; }
        /// <summary>
        /// Total number of packets dropped due to decryption failures.
        /// </summary>
        [JsonProperty(PropertyName = "decryption_failures")]
        public long? DecryptionFailures { get; set; }
        /// <summary>
        /// Total number of packets dropped while sending due to overflow in sequence number.
        /// </summary>
        [JsonProperty(PropertyName = "seq_number_overflow_error")]
        public long? SeqNumberOverflowError { get; set; }
        /// <summary>
        /// Total number of incoming packets on inbound Security association.
        /// </summary>
        [JsonProperty(PropertyName = "packets_in")]
        public long? PacketsIn { get; set; }
        /// <summary>
        /// Specifies the status of tunnel, if it is UP/DOWN.
        /// </summary>
        [JsonProperty(PropertyName = "tunnel_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIpSecVpnTunnelTrafficStatisticsTunnelStatusEnumType? TunnelStatus { get; set; }
        /// <summary>
        /// Policy UUID of IPSec Tunnel.
        /// </summary>
        [JsonProperty(PropertyName = "policy_id")]
        public string? PolicyId { get; set; }
    }
}
