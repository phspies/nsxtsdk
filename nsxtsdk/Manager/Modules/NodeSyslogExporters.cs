// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Newtonsoft.Json;
using System.Net;
using nsxtsdk;
using nsxtsdk.Models;
using nsxtsdk.ManagerModels;

namespace nsxtapi.ManagerModules
{
    public class NodeSyslogExporters
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public NodeSyslogExporters(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTNodeSyslogExporterPropertiesType PostNodeSyslogExporter(NSXTNodeSyslogExporterPropertiesType NodeSyslogExporterProperties)
        {
            if (NodeSyslogExporterProperties == null) { throw new System.ArgumentNullException("NodeSyslogExporterProperties cannot be null"); }
            NSXTNodeSyslogExporterPropertiesType returnValue = default(NSXTNodeSyslogExporterPropertiesType);
            StringBuilder PostNodeSyslogExporterServiceURL = new StringBuilder("/node/services/syslog/exporters");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(NodeSyslogExporterProperties, defaultSerializationSettings));
            request.Resource = PostNodeSyslogExporterServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTNodeSyslogExporterPropertiesType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTNodeSyslogExporterPropertiesListResultType ListNodeSyslogExporters()
        {
            NSXTNodeSyslogExporterPropertiesListResultType returnValue = default(NSXTNodeSyslogExporterPropertiesListResultType);
            StringBuilder ListNodeSyslogExportersServiceURL = new StringBuilder("/node/services/syslog/exporters");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = ListNodeSyslogExportersServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTNodeSyslogExporterPropertiesListResultType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void DeleteNodeSyslogExporterAll()
        {
            
            StringBuilder DeleteNodeSyslogExporterAllServiceURL = new StringBuilder("/node/services/syslog/exporters");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = DeleteNodeSyslogExporterAllServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTNodeSyslogExporterPropertiesType ReadNodeSyslogExporter(string ExporterName)
        {
            if (ExporterName == null) { throw new System.ArgumentNullException("ExporterName cannot be null"); }
            NSXTNodeSyslogExporterPropertiesType returnValue = default(NSXTNodeSyslogExporterPropertiesType);
            StringBuilder ReadNodeSyslogExporterServiceURL = new StringBuilder("/node/services/syslog/exporters/{exporter-name}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadNodeSyslogExporterServiceURL.Replace("{exporter-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(ExporterName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadNodeSyslogExporterServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTNodeSyslogExporterPropertiesType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void DeleteNodeSyslogExporter(string ExporterName)
        {
            if (ExporterName == null) { throw new System.ArgumentNullException("ExporterName cannot be null"); }
            
            StringBuilder DeleteNodeSyslogExporterServiceURL = new StringBuilder("/node/services/syslog/exporters/{exporter-name}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteNodeSyslogExporterServiceURL.Replace("{exporter-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(ExporterName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteNodeSyslogExporterServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void VerifyNodeSyslogExporterVerify()
        {
            
            StringBuilder VerifyNodeSyslogExporterVerifyServiceURL = new StringBuilder("/node/services/syslog/exporters?action=verify");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = VerifyNodeSyslogExporterVerifyServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            
        }
    }
}
