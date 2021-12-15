import-module .\nsxtsdk.dll
$nsxt = connect-nsxt -username admin -password VMware1!VMware1! -host 192.168.0.231
$nsxt | Get-FirewallRules -SectionId "ffffffff-8a04-4924-a5b4-54d30e81befe" -PrettyJson $true

[Console]::ReadKey()