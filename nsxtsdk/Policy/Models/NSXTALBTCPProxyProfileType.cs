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
    /// Advanced load balancer TCPProxyProfile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer TCPProxyProfile object")]
    public class NSXTALBTCPProxyProfileType 
    {
        /// <summary>
        /// Size of the receive window.
        /// Allowed values are 2-65536.
        /// Unit is KB.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 64.
        /// </summary>
        [JsonProperty(PropertyName = "receive_window")]
        public long? ReceiveWindow { get; set; }
        /// <summary>
        /// Controls the our congestion window to send, normally it's 1
        /// mss, If this option is turned on, we use 10 msses.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "aggressive_congestion_avoidance")]
        public bool? AggressiveCongestionAvoidance { get; set; }
        /// <summary>
        /// Controls the congestion control algorithm we use.
        /// Enum options - CC_ALGO_NEW_RENO, CC_ALGO_CUBIC,
        /// CC_ALGO_HTCP.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as CC_ALGO_NEW_RENO.
        /// </summary>
        [JsonProperty(PropertyName = "cc_algo")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbtcpproxyProfileCcAlgoEnumType? CcAlgo { get; set; }
        /// <summary>
        /// Controls the number of duplicate acks required to trigger
        /// retransmission.
        /// Setting a higher value reduces retransmission caused by
        /// packet reordering.
        /// A larger value is recommended in public cloud environments
        /// where packet reordering is quite common.
        /// The default value is 8 in public cloud platforms (AWS,
        /// Azure, GCP), and 3 in other environments.
        /// Allowed values are 1-100.
        /// </summary>
        [JsonProperty(PropertyName = "reorder_threshold")]
        public long? ReorderThreshold { get; set; }
        /// <summary>
        /// The maximum number of attempts at retransmitting a SYN
        /// packet before giving up.
        /// Allowed values are 3-8.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 8.
        /// </summary>
        [JsonProperty(PropertyName = "max_syn_retransmissions")]
        public long? MaxSynRetransmissions { get; set; }
        /// <summary>
        /// The duration for keepalive probes or session idle timeout.
        /// Max value is 3600 seconds, min is 5.
        /// Set to 0 to allow infinite idle time.
        /// Allowed values are 5-14400.
        /// Special values are 0 - 'infinite'.
        /// Unit is SEC.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 600.
        /// </summary>
        [JsonProperty(PropertyName = "idle_connection_timeout")]
        public long? IdleConnectionTimeout { get; set; }
        /// <summary>
        /// Maximum TCP segment size.
        /// Allowed values are 512-9000.
        /// Special values are 0 - 'Use Interface MTU'.
        /// Unit is BYTES.
        /// </summary>
        [JsonProperty(PropertyName = "max_segment_size")]
        public long? MaxSegmentSize { get; set; }
        /// <summary>
        /// Controls the behavior of idle connections.
        /// Enum options - KEEP_ALIVE, CLOSE_IDLE.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as KEEP_ALIVE.
        /// </summary>
        [JsonProperty(PropertyName = "idle_connection_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbtcpproxyProfileIdleConnectionTypeEnumType? IdleConnectionType { get; set; }
        /// <summary>
        /// Controls whether to keep the connection alive with
        /// keepalive messages in the TCP half close state.
        /// The interval for sending keepalive messages is 30s.
        /// If a timeout is already configured in the network profile,
        /// this will not override it.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "keepalive_in_halfclose_state")]
        public bool? KeepaliveInHalfcloseState { get; set; }
        /// <summary>
        /// The time (in millisec) to wait before closing a connection
        /// in the TIME_WAIT state.
        /// Allowed values are 500-2000.
        /// Special values are 0 - 'immediate'.
        /// Unit is MILLISECONDS.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 2000.
        /// </summary>
        [JsonProperty(PropertyName = "time_wait_delay")]
        public long? TimeWaitDelay { get; set; }
        /// <summary>
        /// Congestion window scaling factor after recovery.
        /// Allowed values are 0-8.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 2.
        /// </summary>
        [JsonProperty(PropertyName = "congestion_recovery_scaling_factor")]
        public long? CongestionRecoveryScalingFactor { get; set; }
        /// <summary>
        /// The minimum wait time (in millisec) to retransmit packet.
        /// Allowed values are 50-5000.
        /// Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "min_rexmt_timeout")]
        public long? MinRexmtTimeout { get; set; }
        /// <summary>
        /// Controls whether the windows are static or supports
        /// autogrowth.
        /// Maximum that it can grow to is limited to 4MB.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "auto_window_growth")]
        public bool? AutoWindowGrowth { get; set; }
        /// <summary>
        /// A new SYN is accepted from the same 4-tuple even if there
        /// is already a connection in TIME_WAIT state.
        /// This is equivalent of setting Time Wait Delay to 0.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "ignore_time_wait")]
        public bool? IgnoreTimeWait { get; set; }
        /// <summary>
        /// Maximum number of TCP segments that can be queued for
        /// reassembly.
        /// Configuring this to 0 disables the feature and provides
        /// unlimited queuing.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "reassembly_queue_size")]
        public long? ReassemblyQueueSize { get; set; }
        /// <summary>
        /// Consolidates small data packets to send clients fewer but
        /// larger packets.
        /// Adversely affects real time protocols such as telnet or
        /// SSH.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "nagles_algorithm")]
        public bool? NaglesAlgorithm { get; set; }
        /// <summary>
        /// The number of attempts at retransmit before closing the
        /// connection.
        /// Allowed values are 3-8.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 8.
        /// </summary>
        [JsonProperty(PropertyName = "max_retransmissions")]
        public long? MaxRetransmissions { get; set; }
        /// <summary>
        /// Congestion window scaling factor during slow start.
        /// Allowed values are 0-8.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 1.
        /// </summary>
        [JsonProperty(PropertyName = "slow_start_scaling_factor")]
        public long? SlowStartScalingFactor { get; set; }
        /// <summary>
        /// Dynamically pick the relevant parameters for connections.
        /// Allowed in Basic(Allowed values- true) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "automatic")]
        public bool? Automatic { get; set; }
        /// <summary>
        /// Controls the value of the Differentiated Services Code
        /// Point field inserted in the IP header.
        /// This has two options   Set to a specific value, or Pass
        /// Through, which uses the incoming DSCP value.
        /// Allowed values are 0-63.
        /// Special values are MAX - 'Passthrough'.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "ip_dscp")]
        public long? IpDscp { get; set; }
        /// <summary>
        /// Use the interface MTU to calculate the TCP max segment
        /// size.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "use_interface_mtu")]
        public bool? UseInterfaceMtu { get; set; }
    }
}
