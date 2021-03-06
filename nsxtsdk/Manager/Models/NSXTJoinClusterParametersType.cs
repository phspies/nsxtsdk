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
    /// To join a new node to the NSX cluster, issue a JoinCluster API on the new node. The JoinCluster API takes this object as
        /// a parameter. Provide the ID of the NSX cluster you want the new node to join and the IP address of one of the nodes
        /// already in that cluster. The Cluster Boot Manager running on the new node will then add the new node to the NSX cluster
        /// by making a AttachClusterNode REST API call on the node that is already part of the cluster. In order to make a REST API
        /// call to the node in the cluster, the Cluster Boot Manager will need username and password of a priviledged user on the
        /// node in the cluster. In place of a username and password, Cluster Boot Manager could also use a OAuth token provided.
        /// The Cluster Boot Manager needs either the username and password or the OAuth token to make the REST call but not both.
    /// </summary>
    [NSXTProperty(Description: @"To join a new node to the NSX cluster, issue a JoinCluster API on the new node. The JoinCluster API takes this object as a parameter. Provide the ID of the NSX cluster you want the new node to join and the IP address of one of the nodes already in that cluster. The Cluster Boot Manager running on the new node will then add the new node to the NSX cluster by making a AttachClusterNode REST API call on the node that is already part of the cluster. In order to make a REST API call to the node in the cluster, the Cluster Boot Manager will need username and password of a priviledged user on the node in the cluster. In place of a username and password, Cluster Boot Manager could also use a OAuth token provided. The Cluster Boot Manager needs either the username and password or the OAuth token to make the REST call but not both.")]
    public class NSXTJoinClusterParametersType 
    {
        /// <summary>
        /// Username on the cluster node
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
        /// <summary>
        /// SHA256 Thumbprint of the API certificate of the cluster node
        /// </summary>
        [JsonProperty(PropertyName = "certficate_sha256_thumbprint", Required = Required.AllowNull)]
        public string CertficateSha256Thumbprint { get; set; }
        /// <summary>
        /// Limited time OAuth token instead of the username/password
        /// </summary>
        [JsonProperty(PropertyName = "token")]
        public string? Token { get; set; }
        /// <summary>
        /// UUID of the cluster to join
        /// </summary>
        [JsonProperty(PropertyName = "cluster_id", Required = Required.AllowNull)]
        public string ClusterId { get; set; }
        /// <summary>
        /// Password of the user on the cluster node
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// IP address of a node already part of the cluster to join
        /// </summary>
        [JsonProperty(PropertyName = "ip_address", Required = Required.AllowNull)]
        public string IpAddress { get; set; }
        /// <summary>
        /// API port on the cluster node
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public long? Port { get; set; }
    }
}
