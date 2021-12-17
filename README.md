# C# SDK for NSX-T 3.1

SDK compatable for .net 6.0 for NSX-T 3.1 Manager and Policy engins. It uses RestSharp as the transport method and Newtonsoft.Json for JSON handeling.

## Modules

The Manager and Policy modules are accesible from the same SDK room object in the following manner:

```dotnet
NSXTClient nsxtClient = new NSXTClient("192.168.0.100", "admin", "password");

var clusterStatus = nsxtClient.ManagerEngine.ClusterManagementModule.ReadClusterNodesAggregateStatus();

var infraObject = nsxtClient.PolicyEngine.PolicyModule.ReadInfra("/infra/domains/default");
```

All Types and Enums are prefixed with NSXT to avoid collisions in your projects.

## Custom JsonSerializerSettings

You can pass your own serialization settings as part of the client init code

```dotnet
NSXTClient nsxtClient = new NSXTClient("192.168.0.100", "admin", "password", false, new Newtonsoft.Json.JsonSerializerSettings() {  Formatting = Newtonsoft.Json.Formatting.None });
```