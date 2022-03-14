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
    /// Detail about one error encountered during a probe.
    /// </summary>
    [NSXTProperty(Description: @"Detail about one error encountered during a probe.")]
    public class NSXTLdapProbeErrorType 
    {
        /// <summary>
        /// The cause of the error.
        /// 
        /// BASE_DN_NOT_FOUND: The configured base DN does not exist on the
        /// LDAP server or is not readable.
        /// BIND_DN_AND_PASSWORD_REQUIRED: This server is configured to
        /// require a bind DN and password. Please add these to your
        /// LDAP server configuration.
        /// BIND_DN_INVALID: The bind DN or username provided is not valid
        /// on the LDAP server. Check that the bind DN is correct.
        /// This error may also indicate that the base DN in your
        /// configuration is incorrect.
        /// CERTIFICATE_HOSTNAME_MISMATCH_ERROR: The hostname configured for
        /// the LDAP server does not match the hostname in the server's
        /// certificate subject or alternative subject names. Be sure
        /// that the hostname you configure in NSX Manager matches one
        /// of those names.
        /// CERTIFICATE_MISMATCH_ERROR: The certificate presented by the
        /// LDAP server did not match the certificate in the configuration
        /// on the NSX Manager.
        /// CONNECTION_REFUSED: The connection was refused when contacting the
        /// LDAP server. Ensure that the LDAP server is running and that
        /// you are using the correct ip/hostname.
        /// CONNECTION_TIMEOUT: The connection timed out when contacting
        /// the LDAP server. Check the hostname/ip and any firewalls
        /// between the NSX Manager and the LDAP server.
        /// GENERAL_ERROR: An undetermined error occurred.
        /// INVALID_CONFIGURED_CERTIFICATE: The certificate configured for
        /// this LDAP server is invalid and could not be decoded. Check
        /// that the PEM-formatted certificate you provided is correct.
        /// INVALID_CREDENTIALS: The username and/or password are incorrect.
        /// SSL_HANDSHAKE_ERROR: An error occurred while establishing a secure
        /// connection with the LDAP server. Check that the LDAP server's
        /// certificate is correct, and that it is using an SSL/TLS
        /// cipher suite that is compatible with the NSX Manager.
        /// This error can also occur if the hostname you have configured
        /// for the LDAP server does not match any of the hostnames in
        /// the Subject Alternative Name records in the server
        /// certificate.
        /// STARTTLS_FAILED: Unable to use StartTLS to upgrade the connection
        /// to use TLS. Ensure that the LDAP server supports TLS and if
        /// not, use LDAP or LDAPS as the protocol.
        /// UNKNOWN_HOST: The hostname of the LDAP server could not be
        /// resolved.
        /// NO_ROUTE_TO_HOST: There is no network route to the host.
        /// BIND_EXCEPTION: A socket to the remote host could not be opened.
        /// PORT_UNREACHABLE: The LDAP port is not open on the remote host.
        /// BASE_DN_NOT_WITHIN_DOMAIN: For Active Directory, the base DN
        /// is not a subtree of the Domain Component tree corresponding
        /// to the LDAP domain. For example, if the domain is
        /// "example.com", the baseDN should be "dc=example, dc=com"
        /// or a subtree like "ou=Users,dc=example,dc=com".
        /// LDAP_SERVER_DISABLED: The LDAP server is marked as disabled
        /// in the NSX configuration and will not be used.
        /// </summary>
        public NSXTLdapProbeErrorErrorTypeEnumType? ErrorType { get; set; }
    }
}
