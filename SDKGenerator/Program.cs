using CaseExtensions;
using Nustache.Core;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text.RegularExpressions;
using NSwag;
using NJsonSchema;
using NJsonSchema.References;
using System.Net;
using System.Web;
using System.Text;
using NSwag.Collections;

namespace nsxtapi
{
    class Program
    {
        static string projectDirectory = @"C:\Users\Phillip\source\repos\nsxtsdk\nsxtsdk";
        static string generatorDirectory = @"C:\Users\Phillip\source\repos\nsxtsdk\SDKGenerator";
        static string templatesDirectory = @"C:\Users\Phillip\source\repos\nsxtsdk\SDKGenerator\Templates";
        static void Main(string[] args)
        {


            Helpers.Register(nameof(ToXmlDoc), ToXmlDoc);
            Helpers.Register(nameof(GetMethodName), GetMethodName);
            Helpers.Register(nameof(GetDotNetName), GetDotNetName);
            Helpers.Register(nameof(GetDotNetType), GetDotNetType);
            Helpers.Register(nameof(GetOperationPathParams), GetOperationPathParams);
            Helpers.Register(nameof(GetOperationPathInjectionCode), GetOperationPathInjectionCode);
            Helpers.Register(nameof(GetOperationHttpMethod), GetOperationHttpMethod);
            Helpers.Register(nameof(GetOperationReturnType), GetOperationReturnType);
            Helpers.Register(nameof(GetResponseType), GetResponseType);
            Helpers.Register(nameof(GetPSValueDefinition), GetPSValueDefinition);
            Helpers.Register(nameof(GetResponseTypeName), GetResponseTypeName);
            Helpers.Register(nameof(GetPSVerb), GetPSVerb);
            Helpers.Register(nameof(GetBool), GetBool);
            Helpers.Register(nameof(GetTuple), GetTuple);
            Helpers.Register(nameof(GetLowerCase), GetLowerCase);
            Helpers.Register(nameof(GetCmdLetReturnCode), GetCmdLetReturnCode);
            Helpers.Register(nameof(GetServiceUrl), GetServiceUrl);
            Helpers.Register(nameof(GetResponseName), GetResponseName);
            Helpers.Register(nameof(GetParameterPascalCase), GetParameterPascalCase);
            Helpers.Register(nameof(SetDefaultValue), SetDefaultValue);
            




            var managerApiDocument = OpenApiDocument.FromFileAsync(Path.Combine(generatorDirectory, "nsxt.json")).Result;
            var policyApiDocument = OpenApiDocument.FromFileAsync(Path.Combine(generatorDirectory, "nsxt_policy.json")).Result;

            Directory.CreateDirectory(Path.Combine(projectDirectory, "Manager", "Models"));
            Directory.CreateDirectory(Path.Combine(projectDirectory, "Manager", "Models", "Enums"));
            Directory.CreateDirectory(Path.Combine(projectDirectory, "Manager", "Modules"));
            Directory.CreateDirectory(Path.Combine(projectDirectory, "Policy", "Models"));
            Directory.CreateDirectory(Path.Combine(projectDirectory, "Policy", "Models", "Enums"));
            Directory.CreateDirectory(Path.Combine(projectDirectory, "Policy", "Modules"));
            Directory.CreateDirectory(Path.Combine(projectDirectory, "Powershell", "Manager"));
            Directory.CreateDirectory(Path.Combine(projectDirectory, "Powershell", "Policy"));
            Directory.CreateDirectory(Path.Combine(projectDirectory, "Models"));

            JsonSchemaReferenceUtilities.UpdateSchemaReferencePaths(managerApiDocument);
            JsonSchemaReferenceUtilities.UpdateSchemaReferencePaths(policyApiDocument);

            //Get list of all the NSX-T mpdules & responses
            List<string> managerModules = managerApiDocument.Paths.Values.SelectMany(x => x.Values.SelectMany(y => y.ExtensionData.Where(z => z.Key == "x-vmw-nsx-module").Select(f => f.Value.ToString()))).Distinct().ToList();
            List<string> policyModules = policyApiDocument.Paths.Values.SelectMany(x => x.Values.SelectMany(y => y.ExtensionData.Where(z => z.Key == "x-vmw-nsx-module").Select(f => f.Value.ToString()))).Distinct().ToList();

            //Generate root api objects
            Render.FileToFile(Path.Combine(generatorDirectory, "Templates", "RootModule.cs.template"), new
            {
                rootmodule = "Manager",
                rootURL = @"/api/v1",
                modules = managerModules,
            }, Path.Combine(projectDirectory, $"ManagerClient.cs"));
            Render.FileToFile(Path.Combine(generatorDirectory, "Templates", "RootModule.cs.template"), new
            {
                rootmodule = "Policy",
                rootURL = @"/policy/api/v1",
                modules = policyModules,
            }, Path.Combine(projectDirectory, $"PolicyClient.cs"));

            //Generate module refercen classes
            foreach (var module in managerModules)
            {
                Render.FileToFile(Path.Combine(generatorDirectory, "Templates", "Module.cs.template"), new
                {
                    rootmodule = "Manager",
                    module,
                    operations = managerApiDocument.Paths.Where(x => x.Value.Any(y => y.Value.ExtensionData.Values.Contains(module)))
                }, Path.Combine(projectDirectory, "Manager", "Modules", $"{module}.cs"));
            }
            foreach (var module in policyModules)
            {
                Render.FileToFile(Path.Combine(generatorDirectory, "Templates", "Module.cs.template"), new
                {
                    module,
                    rootmodule = "Policy",
                    operations = policyApiDocument.Paths.Where(x => x.Value.Any(y => y.Value.ExtensionData.Values.Contains(module)))
                }, Path.Combine(projectDirectory, "Policy", "Modules", $"{module}.cs"));
            }




            //foreach (var module in managerModules)
            //{
            //    Render.FileToFile(Path.Combine(generatorDirectory, "Templates", "PSCmdLet.cs.template"), new
            //    {
            //        module,
            //        operations = managerApiDocument.Paths.Where(x => x.Value.Any(y => y.Value.ExtensionData.Values.Contains(module)))
            //    }, Path.Combine(projectDirectory, "Powershell", "Manager", $"{module}.cs"));
            //}
            //foreach (var module in policyModules)
            //{
            //    Render.FileToFile(Path.Combine(generatorDirectory, "Templates", "PSCmdLet.cs.template"), new
            //    {
            //        module,
            //        operations = managerApiDocument.Paths.Where(x => x.Value.Any(y => y.Value.ExtensionData.Values.Contains(module)))
            //    }, Path.Combine(projectDirectory, "Powershell", "Policy", $"{module}.cs"));
            //}

            Render.FileToFile(Path.Combine(generatorDirectory, "Templates", "Response.cs.template"), new
            {
                responses = managerApiDocument.Responses,
            }, Path.Combine(projectDirectory, "Models", $"NSXTRestResponses.cs"));

            foreach (var (clz, def) in policyApiDocument.Definitions)
            {
                string module = def.ExtensionData.FirstOrDefault(x => x.Key == "x-vmw-nsx-module").Value.ToString();
                if (def.AllOf.Count > 1)
                {
                    string discriminator = null;
                    List<string> inheritanceClasses = new();
                    if (def.AllOf.Any(x => x.Discriminator != null))
                    {
                        discriminator = def.AllOf.First(x => x.Discriminator != null).Discriminator;
                        foreach (var (classValue, value) in policyApiDocument.Definitions)
                        {
                            if (value.AllOf.Any(y => y.HasReference && ((IJsonReferenceBase)y).ReferencePath.Split("/")[3] == clz))
                            {
                                inheritanceClasses.Add(classValue);
                            }
                        }
                    }
                    Render.FileToFile(Path.Combine(generatorDirectory, "Templates", "Model.cs.template"), new
                    {
                        inheritanceClasses = inheritanceClasses,
                        discriminator = discriminator,
                        clz,
                        module = module,
                        rootmodule = "Policy",
                        referenced = $": {String.Join(",", def.AllOf.Where(x => x.Reference != null).Select(x => $"NSXT{((IJsonReferenceBase)x).ReferencePath.Split("/")[3]}Type"))}",
                        def = def.AllOf.FirstOrDefault(x => x.Properties.Count > 0),
                        properties = def.Properties.Values,
                    }, Path.Combine(projectDirectory, "Policy", "Models", $"NSXT{clz}Type.cs"));

                    if (def.AllOf.Any(x => x.Properties.Count > 0))
                    {
                        foreach (var prop in def.AllOf.FirstOrDefault(x => x.Properties.Count > 0).Properties)
                        {
                            if (prop.Value.Enumeration.Count > 0)
                            {
                                EnumType currentEnum = new EnumType();
                                currentEnum.EnumName = PascalCase($"NSXT {clz} {prop.Key} enum type"); ;
                                currentEnum.Description = prop.Value.Description;
                                foreach (var enumValue in prop.Value.Enumeration)
                                {
                                    int index = 1;
                                    if (currentEnum.Values.Count > 0)
                                    {
                                        index = (string)prop.Value.Default == (string)enumValue ? 0 : currentEnum.Values.Last().EnumIndex + 1;
                                    }
                                    currentEnum.Values.Add(new EnumValueType() { EnumValue = char.IsDigit(((string)enumValue)[0]) ? "A" + PascalCase(enumValue as string) : PascalCase(enumValue as string), JsonEnumValue = (enumValue as string).Replace(" ", "_").ToUpper(), EnumIndex = index });
                                }
                                Render.FileToFile(Path.Combine(generatorDirectory, "Templates", "EnumModel.cs.template"), new
                                {
                                    rootmodule = "Policy",
                                    currentEnum
                                }, Path.Combine(projectDirectory, "Policy", "Models", "Enums", $"{currentEnum.EnumName}.cs"));
                            }
                        }
                    }
                }
                else
                {
                    Render.FileToFile(Path.Combine(generatorDirectory, "Templates", "Model.cs.template"), new
                    {
                        rootmodule = "Policy",
                        clz,
                        module = module,
                        def,
                        properties = def.Properties.Values,
                    }, Path.Combine(projectDirectory, "Policy", "Models", $"NSXT{clz}Type.cs"));

                    foreach (var prop in def.Properties)
                    {
                        if (prop.Value.Enumeration.Count > 0)
                        {
                            EnumType currentEnum = new EnumType();
                            currentEnum.EnumName = PascalCase($"NSXT {clz} {prop.Key} enum type"); ;
                            currentEnum.Description = prop.Value.Description;
                            foreach (var enumValue in prop.Value.Enumeration)
                            {
                                int index = 1;
                                if (currentEnum.Values.Count > 0)
                                {
                                    index = (string)prop.Value.Default == (string)enumValue ? 0 : currentEnum.Values.Last().EnumIndex + 1;
                                }
                                currentEnum.Values.Add(new EnumValueType() { EnumValue = PascalCase(enumValue as string), JsonEnumValue = (enumValue as string).Replace(" ", "_").ToUpper(), EnumIndex = index });
                            }
                            Render.FileToFile(Path.Combine(generatorDirectory, "Templates", "EnumModel.cs.template"), new
                            {
                                rootmodule = "Policy",
                                currentEnum
                            }, Path.Combine(projectDirectory, "Policy", "Models", "Enums", $"{currentEnum.EnumName}.cs"));
                        }
                    }
                }

            }
            foreach (var (clz, def) in managerApiDocument.Definitions)
            {
                string module = def.ExtensionData.FirstOrDefault(x => x.Key == "x-vmw-nsx-module").Value.ToString();
                if (def.AllOf.Count == 2)
                {
                    Render.FileToFile(Path.Combine(generatorDirectory, "Templates", "Model.cs.template"), new
                    {
                        clz,
                        module = module,
                        rootmodule = "Manager",
                        referenced = $": {String.Join(",", def.AllOf.Where(x => x.Reference != null).Select(x => $"NSXT{((IJsonReferenceBase)x).ReferencePath.Split("/")[3]}Type"))}",
                        def = def.AllOf.FirstOrDefault(x => x.Properties.Count > 0),
                        properties = def.Properties.Values,
                    }, Path.Combine(projectDirectory, "Manager", "Models", $"NSXT{clz}Type.cs"));

                    if (def.AllOf.Any(x => x.Properties.Count > 0))
                    {
                        foreach (var prop in def.AllOf.FirstOrDefault(x => x.Properties.Count > 0).Properties)
                        {
                            if (prop.Value.Enumeration.Count > 0)
                            {
                                EnumType currentEnum = new EnumType();
                                currentEnum.EnumName = PascalCase($"NSXT {clz} {prop.Key} enum type"); ;
                                currentEnum.Description = prop.Value.Description;
                                foreach (var enumValue in prop.Value.Enumeration)
                                {
                                    int index = 1;
                                    if (currentEnum.Values.Count > 0)
                                    {
                                        index = (string)prop.Value.Default == (string)enumValue ? 0 : currentEnum.Values.Last().EnumIndex + 1;
                                    }
                                    currentEnum.Values.Add(new EnumValueType() { EnumValue = char.IsDigit(((string)enumValue)[0]) ? "A" + PascalCase(enumValue as string) : PascalCase(enumValue as string), JsonEnumValue = (enumValue as string).Replace(" ", "_").ToUpper(), EnumIndex = index });
                                }
                                Render.FileToFile(Path.Combine(generatorDirectory, "Templates", "EnumModel.cs.template"), new
                                {
                                    rootmodule = "Manager",
                                    currentEnum
                                }, Path.Combine(projectDirectory, "Manager", "Models", "Enums", $"{currentEnum.EnumName}.cs"));
                            }
                        }
                    }
                }
                else
                {
                    Render.FileToFile(Path.Combine(generatorDirectory, "Templates", "Model.cs.template"), new
                    {
                        rootmodule = "Manager",
                        clz,
                        module = module,
                        def,
                        properties = def.Properties.Values,
                    }, Path.Combine(projectDirectory, "Manager", "Models", $"NSXT{clz}Type.cs"));

                    foreach (var prop in def.Properties)
                    {
                        if (prop.Value.Enumeration.Count > 0)
                        {
                            EnumType currentEnum = new EnumType();
                            currentEnum.EnumName = PascalCase($"NSXT {clz} {prop.Key} enum type"); ;
                            currentEnum.Description = prop.Value.Description;
                            foreach (var enumValue in prop.Value.Enumeration)
                            {
                                int index = 1;
                                if (currentEnum.Values.Count > 0)
                                {
                                    index = (string)prop.Value.Default == (string)enumValue ? 0 : currentEnum.Values.Last().EnumIndex + 1;
                                }
                                currentEnum.Values.Add(new EnumValueType() { EnumValue = PascalCase(enumValue as string), JsonEnumValue = (enumValue as string).Replace(" ", "_").ToUpper(), EnumIndex = index });
                            }
                            Render.FileToFile(Path.Combine(generatorDirectory, "Templates", "EnumModel.cs.template"), new
                            {
                                rootmodule = "Manager",
                                currentEnum
                            }, Path.Combine(projectDirectory, "Manager", "Models", "Enums", $"NSXT{currentEnum.EnumName}.cs"));
                        }
                    }
                }

            }


        }

        private string ConvertToString(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (value == null)
            {
                return "";
            }

            if (value is System.Enum)
            {
                var name = System.Enum.GetName(value.GetType(), value);
                if (name != null)
                {
                    var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                    if (field != null)
                    {
                        var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute))
                            as System.Runtime.Serialization.EnumMemberAttribute;
                        if (attribute != null)
                        {
                            return attribute.Value != null ? attribute.Value : name;
                        }
                    }

                    var converted = System.Convert.ToString(System.Convert.ChangeType(value, System.Enum.GetUnderlyingType(value.GetType()), cultureInfo));
                    return converted == null ? string.Empty : converted;
                }
            }
            else if (value is bool)
            {
                return System.Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
            }
            else if (value is byte[])
            {
                return System.Convert.ToBase64String((byte[])value);
            }
            else if (value.GetType().IsArray)
            {
                var array = System.Linq.Enumerable.OfType<object>((System.Array)value);
                return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
            }

            var result = System.Convert.ToString(value, cultureInfo);
            return result == null ? "" : result;
        }
        private static void GetServiceUrl(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var (method, operation) = ((KeyValuePair<string, OpenApiPathItem>)arguments[0]);
            context.Write($"{method}");
        }
        private static void SetDefaultValue(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            //var (method, operation) = ((KeyValuePair<string, OpenApiPathItem>)arguments[0]);
            context.Write($"test");
        }
        private static void GetCmdLetReturnCode(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var parameter = (OpenApiParameter)arguments[0];
            context.Write($"{GetDotNetType(parameter)} {PascalCase(parameter.Name)}");
        }
        private static void GetParameterPascalCase(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var parameter = (string)arguments[0];
            context.Write($"{PascalCase(parameter)}");
        }
        private static void GetPSValueDefinition(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var parameter = (OpenApiParameter)arguments[0];
            context.Write($"{GetDotNetType(parameter)} {PascalCase(parameter.Name)}");
        }
        private static void GetPSVerb(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var (method, operation) = (KeyValuePair<string, OpenApiOperation>)arguments[0];
            string module = arguments[1] as string;
            List<string> list = StringSplitter(operation.OperationId);
            context.Write($"\"{list[0]}\",\"{module}{PascalCase(string.Join("", list.GetRange(1, list.Count - 1)))}\"");
        }
        private static void GetResponseTypeName(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var response = (OpenApiResponse)arguments[0];
            context.Write($"NSXT{((IJsonReferenceBase)response.Schema).ReferencePath.Split("/")[3]}Type");
        }
        private static void ToXmlDoc(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            if (arguments != null && arguments.Count > 0 && arguments[0] != null && arguments[0] is string)
            {
                var first = true;
                using (var reader = new StringReader(arguments[0] as string))
                {
                    string line = null;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (arguments.Count > 1 && arguments[1] as string == "wrap")
                        {
                            foreach (var wline in WordWrap(line, 120))
                            {
                                if (!first)
                                {
                                    context.Write("\r\n        /// ");
                                }
                                else
                                {
                                    first = false;
                                }

                                context.Write(HttpUtility.HtmlDecode(wline));
                            }
                        }
                        else
                        {
                            context.Write(SecurityElement.Escape(line.Replace("\n", "").Replace("\r", "")));
                        }
                    }
                }
            }
        }

        private static void GetOperationPathParams(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var (method, operation) = ((KeyValuePair<string, OpenApiOperation>)arguments[0]);
            List<string> returnList = new();
            foreach (var parameter in operation.Parameters.OrderByDescending(x => x.IsRequired))
            {
                returnList.Add($"{GetDotNetType(parameter)} {PascalCase(parameter.Name)}" + (parameter.IsRequired ? "" : " = null"));
            }
            context.Write(string.Join(", ", returnList));
        }

        private static void GetOperationReturnType(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var (method, operation) = ((KeyValuePair<string, OpenApiOperation>)arguments[0]);
            var response = operation.Responses.FirstOrDefault(x => x.Key.StartsWith("20"));
            if (response.Value.Schema != null)
            {
                if (response.Value.Schema?.Reference != null)
                {
                    string className = $"NSXT{((IJsonReferenceBase)response.Value.Schema).ReferencePath.Split("/")[3]}Type";
                    if (arguments[1] as string == "full")
                    {
                        context.Write($"{className}");
                    }
                    else if (arguments[1] as string == "bare")
                    {
                        context.Write(className);
                    }
                    else if (arguments[1] as string == "init")
                    {
                        context.Write($"{className} returnValue = default({className});");
                    }
                    else if (arguments[1] as string == "cast")
                    {
                        context.Write($"returnValue = JsonConvert.DeserializeObject<{className}>(response.Content, defaultSerializationSettings);");
                    }
                    else if (arguments[1] as string == "return")
                    {
                        var okResponse = operation.Responses.FirstOrDefault(x => x.Key.StartsWith("20"));
                        if (okResponse.Value.Schema != null)
                        {
                            context.Write("else");
                            context.Write("\r\n\t\t\t{");
                            context.Write("\r\n\t\t\t\ttry");
                            context.Write("\r\n\t\t\t\t{");
                            context.Write($"\r\n\t\t\t\t\treturnValue = JsonConvert.DeserializeObject<NSXT{((IJsonReferenceBase)okResponse.Value.Schema).ReferencePath.Split("/")[3]}Type>(response.Content, defaultSerializationSettings);");
                            context.Write("\r\n\t\t\t\t}");
                            context.Write("\r\n\t\t\t\tcatch (Exception ex)");
                            context.Write("\r\n\t\t\t\t{");
                            context.Write("\r\n\t\t\t\t\t" + @"var message = ""Could not deserialize the response body string as "" + typeof(" + className + @").FullName + ""."";");
                            context.Write("\r\n\t\t\t\t\t" + @"throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);");
                            context.Write("\r\n\t\t\t\t}");
                            context.Write("\r\n\t\t\t}");
                            context.Write("\r\n\t\t\treturn returnValue;");
                        }
                    }
                    else if (arguments[1] as string == "cmdlet")
                    {
                        context.Write($"[OutputType(typeof({className}))]");
                    }
                    else if (arguments[1] as string == "cmdletreturn")
                    {
                        string module = arguments[2] as string;
                        string operationId = operation.OperationId;
                        List<string> returnList = new List<string>();
                        foreach (var parameter in operation.Parameters.OrderByDescending(x => x.IsRequired))
                        {
                            returnList.Add($"{PascalCase(parameter.Name)}");
                        }
                        context.Write($"var returnobject = _client.{module}Module.{PascalCase(operationId)}({string.Join(", ", returnList)});");
                    }
                }
                else if (response.Value.Schema?.Type != JsonObjectType.None)
                {
                    string className = response.Value.Schema.Type.ToString().ToLower();
                    if (arguments[1] as string == "full")
                    {
                        context.Write($"{className}");
                    }
                    else if (arguments[1] as string == "bare")
                    {
                        context.Write($"{className}");
                    }
                    else if (arguments[1] as string == "init")
                    {
                        context.Write($"{className} returnValue  = default({className});");
                    }
                    else if (arguments[1] as string == "cast")
                    {
                        context.Write($"returnValue = JsonConvert.DeserializeObject<{className}>(response.Content, defaultSerializationSettings);");
                    }
                    else if (arguments[1] as string == "return")
                    {
                        var okResponse = operation.Responses.FirstOrDefault(x => x.Key.StartsWith("20"));
                        if (okResponse.Value.Schema != null)
                        {
                            context.Write("else");
                            context.Write("\r\n\t\t\t{");
                            context.Write("\r\n\t\t\t\ttry");
                            context.Write("\r\n\t\t\t\t{");
                            context.Write($"\r\n\t\t\t\t\treturnValue = JsonConvert.DeserializeObject<" + okResponse.Value.Schema.Type.ToString().ToLower() + @">(response.Content, defaultSerializationSettings);");
                            context.Write("\r\n\t\t\t\t}");
                            context.Write("\r\n\t\t\t\tcatch (Exception ex)");
                            context.Write("\r\n\t\t\t\t{");
                            context.Write("\r\n\t\t\t\t\t" + @"var message = ""Could not deserialize the response body string as "" + typeof(" + className + @").FullName + ""."";");
                            context.Write("\r\n\t\t\t\t\t" + @"throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);");
                            context.Write("\r\n\t\t\t\t}");
                            context.Write("\r\n\t\t\t}");
                            context.Write("\r\n\t\t\treturn returnValue;");
                        }
                    }
                    else if (arguments[1] as string == "cmdlet")
                    {
                        context.Write($"[OutputType(typeof({className}))]");
                    }
                    else if (arguments[1] as string == "cmdletreturn")
                    {
                        string module = arguments[2] as string;
                        string operationId = operation.OperationId;
                        List<string> returnList = new List<string>();
                        foreach (var parameter in operation.Parameters.OrderByDescending(x => x.IsRequired))
                        {
                            returnList.Add($"{PascalCase(parameter.Name)}");
                        }
                        context.Write($"var returnobject = _client.{module}Module.{PascalCase(operationId)}({string.Join(", ", returnList)});");
                    }
                }
            }
            else
            {
                if (arguments[1] as string == "full")
                {
                    context.Write("void");
                }
                else if (arguments[1] as string == "bare")
                {
                }
                else if (arguments[1] as string == "init")
                {
                }
                else if (arguments[1] as string == "cast")
                {
                }
                else if (arguments[1] as string == "return")
                {
                }
                else if (arguments[1] as string == "cmdlet")
                {

                }
                else if (arguments[1] as string == "cmdletreturn")
                {
                    string module = arguments[2] as string;
                    string operationId = operation.OperationId;
                    List<string> returnList = new();
                    foreach (var parameter in operation.Parameters.OrderByDescending(x => x.IsRequired))
                    {
                        returnList.Add($"{PascalCase(parameter.Name)}: {PascalCase(parameter.Name)}");
                    }
                    context.Write($"object returnobject = null; _client.{module}Module.{PascalCase(operationId)}({string.Join(", ", returnList)});");
                }
            }

        }
        private static void GetOperationHttpMethod(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            context.Write((arguments[0] as String).ToUpper());

        }
        private static void GetResponseType(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            ObservableDictionary<string, OpenApiResponse> responseList = arguments[0] as ObservableDictionary<string, OpenApiResponse>;
            var okResponse = responseList.FirstOrDefault(x => x.Key.StartsWith("20"));

            if (okResponse.Value.Schema != null)
            {
                if (okResponse.Value.Schema?.Reference != null)
                {
                    context.Write($"returnValue = JsonConvert.DeserializeObject<NSXT{((IJsonReferenceBase)okResponse.Value.Schema).ReferencePath.Split("/")[3]}Type>(response.Content, defaultSerializationSettings);");
                }
                else if (okResponse.Value.Schema?.Type != JsonObjectType.None)
                {
                    context.Write($"returnValue = JsonConvert.DeserializeObject<{okResponse.Value.Schema.Type.ToString().ToLower()}>(response.Content, defaultSerializationSettings);");
                }
            }

        }

        private static void GetOperationPathInjectionCode(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var parameter = (arguments[0] as OpenApiParameter);
            if (parameter.Kind == OpenApiParameterKind.Path)
            {
                context.Write($"{PascalCase((parameter.Parent as OpenApiOperation).OperationId)}ServiceURL.Replace(\"{{{parameter.Name}}}\", System.Uri.EscapeDataString(Helpers.ConvertToString({PascalCase(parameter.Name)}, System.Globalization.CultureInfo.InvariantCulture)));");
            }
            if (parameter.Kind == OpenApiParameterKind.Query)
            {
                context.Write($"if ({PascalCase(parameter.Name)} != null) {{ request.AddQueryParameter(\"{parameter.Name}\", {PascalCase(parameter.Name)}.ToString()); }}");
            }
            if (parameter.Kind == OpenApiParameterKind.Body)
            {
                context.Write($"request.AddJsonBody(JsonConvert.SerializeObject({PascalCase(parameter.Name)}, defaultSerializationSettings));");
            }
        }

        private static void GetLowerCase(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var test = arguments[0];
            context.Write(arguments[0]?.ToString()?.ToLower());
        }
        private static void GetBool(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var test = arguments[0];
            context.Write(Boolean.Parse(arguments[0]?.ToString()).ToString());
        }
        private static void GetTuple(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            if (arguments != null && arguments.Count > 0 && arguments[0] is ITuple && options.TryGetValue("index", out var indexObj) && int.TryParse(indexObj?.ToString(), out var index))
            {
                var pair = (ITuple)arguments[0];
                var value = pair[index];
                context.Write(value.ToString());
            }
        }

        private static void GetMethodName(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var (method, operation) = ((KeyValuePair<string, OpenApiOperation>)arguments[0]);
            if (arguments.Count == 2)
            {
                var (path, pathItem) = ((KeyValuePair<string, OpenApiPathItem>)arguments[1]);
                if (path.Contains("global-infra"))
                {
                    context.Write($"Global{PascalCase(operation.OperationId)}");
                }
                else
                {
                    context.Write(PascalCase(operation.OperationId));
                }
            }
            else
            {
                context.Write(PascalCase(operation.OperationId));
            }

        }
        private static void GetResponseName(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var (response, operation) = ((KeyValuePair<string, OpenApiResponse>)arguments[0]);
            context.Write(PascalCase(response));
        }


        private static void GetDotNetType(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            if (arguments != null && arguments.Count > 0 && arguments[0] != null && arguments[0] is JsonSchemaProperty)
            {
                var parameter = arguments[0] as JsonSchemaProperty;

                if (parameter.Reference != null)
                {
                    if ("IpSecVpnPolicyTrafficStatistics".ToLower() == ((IJsonReferenceBase)parameter).ReferencePath.Split("/")[3].ToLower())
                    {
                        Console.WriteLine("foiund");
                    }
                    context.Write(GetDotNetType(parameter, arguments));
                }
                else if (parameter != null)
                {
                    context.Write(GetDotNetType(parameter, arguments));
                }
            }
        }
        private static string GetDotNetType(OpenApiParameter parameter)
        {
            if (parameter.Schema != null)
            {
                return $"NSXT{((IJsonReferenceBase)parameter.Schema).ReferencePath.Split("/")[3]}Type{(parameter.IsRequired ? "" : "?")}";
            }
            switch (parameter.Type)
            {
                case JsonObjectType.Boolean:
                    return $"bool{(parameter.IsRequired ? "" : "?")}";
                case JsonObjectType.Integer:
                    switch (parameter.Format)
                    {
                        case "int64":
                            return $"long{(parameter.IsRequired ? "" : "?")}";
                        case "int32":
                        default:
                            return $"int{(parameter.IsRequired ? "" : "?")}";
                    }
                case JsonObjectType.Number:
                    return $"double{(parameter.IsRequired ? "" : "?")}";
                case JsonObjectType.String:
                    switch (parameter.Format)
                    {
                        case "byte":
                            return "byte[]";
                        case "date-time":
                            return $"System.DateTime{(parameter.IsRequired ? "" : "?")}";
                    }
                    return parameter.IsRequired ? "string" : "string?";
                case JsonObjectType.File:
                    return $"string{(parameter.IsRequired ? "" : "?")}";
                default:
                    //throw new NotSupportedException();
                    Console.WriteLine($"{parameter.Type} for {parameter.Name} not handeled");
                    return "object";

            }
        }
        private static string GetDotNetType(JsonSchemaProperty jsonType, IList<object> arguments)
        {
            if (jsonType.Name == "nodes")
            {

            }
            switch (jsonType.Type)
            {
                case JsonObjectType.Boolean:
                    if (jsonType.IsRequired)
                    {
                        return "bool";
                    }
                    else
                    {
                        return "bool?";
                    }

                case JsonObjectType.Integer:
                    switch (jsonType.Format)
                    {
                        case "int64":
                            if (jsonType.IsRequired)
                            {
                                return "long";
                            }
                            else
                            {
                                return "long?";
                            }
                        case "int32":
                        default:
                            if (jsonType.IsRequired)
                            {
                                return "int";
                            }
                            else
                            {
                                return "int?";
                            }
                    }

                case JsonObjectType.Number:
                    if (jsonType.IsRequired)
                    {
                        return "double";
                    }
                    else
                    {
                        return "double?";
                    }

                case JsonObjectType.String:
                    if (jsonType.Enumeration != null && jsonType.Enumeration.Count > 0)
                    {
                        return PascalCase($"NSXT {arguments[2]} {arguments[1]} enum type {(!jsonType.IsRequired ? "?" : "")}");
                    }
                    switch (jsonType.Format)
                    {
                        case "byte":
                            return "byte[]";
                        case "date-time":
                            if (jsonType.IsRequired)
                            {
                                return "System.DateTime";
                            }
                            else
                            {
                                return "System.DateTime?";
                            }
                    }
                    return jsonType.IsRequired ? "string" : "string?";
                case JsonObjectType.Array:
                    if (jsonType.Item?.Reference != null)
                    {
                        string _type = ((IJsonReferenceBase)jsonType.Item).ReferencePath.Split("/")[3];
                        //We need to manually set some of these types as the NSX-T Swagger definition is broken in some places.
                        if (_type.ToLower() == "IpInfo".ToLower())
                        {
                            _type = "IPInfo";
                        }
                        if (_type.ToLower() == "Snmpv3User".ToLower())
                        {
                            _type = "SnmpV3User";
                        }
                        return $"IList<NSXT{_type}Type>";
                    }
                    else
                    {
                        if (jsonType.Type == JsonObjectType.Array)
                        {
                            if (jsonType.Item.Type == JsonObjectType.Integer)
                            {
                                switch (jsonType.Item.Format)
                                {
                                    case "int64":
                                        if (jsonType.IsRequired)
                                        {
                                            return "long";
                                        }
                                        else
                                        {
                                            return "long?";
                                        }
                                    case "int32":
                                    default:
                                        if (jsonType.IsRequired)
                                        {
                                            return "int";
                                        }
                                        else
                                        {
                                            return "int?";
                                        }
                                }
                            }
                            else
                            {
                                if (jsonType.Item.Reference != null)
                                {
                                    return $"IList<NSXT{((IJsonReferenceBase)jsonType.Item).ReferencePath.Split("/")[3]}Type>";
                                }
                                else
                                {
                                    string _type = jsonType.Item.Type.ToString().ToLower();
                                    if (_type == "number")
                                    {
                                        _type = "float";
                                    }
                                    return $"IList<{_type}>";
                                }
                            }
                        }
                        else
                        {
                            throw new NotSupportedException();

                        }
                    }
                case JsonObjectType.Object:
                    if (jsonType.IsRequired)
                    {
                        return "object";
                    }
                    else
                    {
                        return "object?";
                    }
                case JsonObjectType.None:
                    if (jsonType.Reference != null)
                    {
                        string _type = ((IJsonReferenceBase)jsonType).ReferencePath.Split("/")[3];
                        //We need to manually set some of these types as the NSX-T Swagger definition is broken in some places.
                        if (_type.ToLower() == "IpInfo".ToLower())
                        {
                            _type = "IPInfo";
                        }
                        if (_type.ToLower() == "Snmpv3User".ToLower())
                        {
                            _type = "SnmpV3User";
                        }
                        return $"NSXT{_type}Type";
                    }
                    else
                    {
                        return "object";
                    }
                default:
                    throw new NotSupportedException();
            }
        }



        private static void GetDotNetName(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            if (arguments != null && arguments.Count > 0 && arguments[0] != null && arguments[0] is JsonSchemaProperty)
            {
                var parameter = arguments[0] as JsonSchemaProperty;
                context.Write(PascalCase(parameter.Name));
            }
            else if (arguments != null && arguments.Count > 0 && arguments[0] != null && arguments[0] is OpenApiParameter)
            {
                var parameter = arguments[0] as OpenApiParameter;
                context.Write(GetDotNetName(parameter.Name));
                if (arguments.Count > 1 && arguments[1] as string == "true" && !parameter.IsRequired)
                {
                    context.Write($" = null");
                }
            }
            else if (arguments != null && arguments.Count > 0 && arguments[0] != null && arguments[0] is string)
            {
                var style = "parameter";
                if (arguments.Count > 1)
                {
                    style = arguments[1] as string;
                }

                context.Write(GetDotNetName((string)arguments[0], style));
            }
            else
            {
                context.Write("fieldname");
            }
        }

        private static string GetDotNetName(string jsonName, string style = "parameter")
        {
            switch (style)
            {
                case "parameter":
                    if (jsonName == "namespace")
                    {
                        return "namespaceParameter";
                    }
                    else if (jsonName == "continue")
                    {
                        return "continueParameter";
                    }

                    break;

                case "fieldctor":
                    if (jsonName == "namespace")
                    {
                        return "namespaceProperty";
                    }
                    else if (jsonName == "continue")
                    {
                        return "continueProperty";
                    }
                    else if (jsonName == "__referencePath")
                    {
                        return "refProperty";
                    }
                    else if (jsonName == "default")
                    {
                        return "defaultProperty";
                    }
                    else if (jsonName == "operator")
                    {
                        return "operatorProperty";
                    }
                    else if (jsonName == "$schema")
                    {
                        return "schema";
                    }
                    else if (jsonName == "enum")
                    {
                        return "enumProperty";
                    }
                    else if (jsonName == "object")
                    {
                        return "objectProperty";
                    }
                    else if (jsonName == "readOnly")
                    {
                        return "readOnlyProperty";
                    }
                    else if (jsonName == "from")
                    {
                        return "fromProperty";
                    }
                    return jsonName.ToCamelCase();
                case "field":
                    return GetDotNetName(jsonName, "fieldctor").ToPascalCase();
            }
            return jsonName.ToCamelCase();
        }



        private static string ToPascalCase(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return name;
            }
            return char.ToUpper(name[0]) + name.Substring(1);
        }
        public static string PascalCase(string str)
        {
            if (str != null)
            {
                TextInfo cultInfo = new CultureInfo("en-US", false).TextInfo;
                str = Regex.Replace(str, "([A-Z]+)", " $1");
                str = cultInfo.ToTitleCase(str);
                str = str.Replace(" ", "");
                str = str.Replace("_", "");
                str = str.Replace("-", "");
                str = str.Replace("+", "_");
            }
            return str;
        }

        public static IEnumerable<string> WordWrap(string text, int width)
        {
            var lines = text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            foreach (var line in lines)
            {
                var processedLine = line.Trim();

                // yield empty lines as they are (probably) intensional
                if (processedLine.Length == 0)
                {
                    yield return processedLine;
                }

                // feast on the line until it's gone
                while (processedLine.Length > 0)
                {
                    // determine potential wrapping points
                    var whitespacePositions = Enumerable
                        .Range(0, processedLine.Length)
                        .Where(i => char.IsWhiteSpace(processedLine[i]))
                        .Concat(new[] { processedLine.Length })
                        .Cast<int?>();
                    var preWidthWrapAt = whitespacePositions.LastOrDefault(i => i <= width);
                    var postWidthWrapAt = whitespacePositions.FirstOrDefault(i => i > width);

                    // choose preferred wrapping point
                    var wrapAt = preWidthWrapAt ?? postWidthWrapAt ?? processedLine.Length;

                    // wrap
                    yield return processedLine.Substring(0, wrapAt);
                    processedLine = processedLine.Substring(wrapAt).Trim();
                }
            }
        }
        static List<string> StringSplitter(string stringToSplit)
        {
            List<string> result = new List<string>();
            bool wasPreviousUppercase = false;
            StringBuilder current = new StringBuilder();

            foreach (char c in stringToSplit)
            {
                if (char.IsUpper(c))
                {
                    if (wasPreviousUppercase)
                    {
                        current.Append(c);
                    }
                    else
                    {
                        if (current.Length > 0)
                        {
                            result.Add(current.ToString());
                            current.Length = 0;
                        }

                        current.Append(c);
                    }

                    wasPreviousUppercase = true;
                }
                else  // lowercase
                {
                    if (wasPreviousUppercase)
                    {
                        if (current.Length > 1)
                        {
                            char carried = current[current.Length - 1];
                            --current.Length;
                            result.Add(current.ToString());
                            current.Length = 0;
                            current.Append(carried);
                        }
                    }

                    wasPreviousUppercase = false;

                    if (current.Length == 0)
                    {
                        current.Append(char.ToUpper(c));
                    }
                    else
                    {
                        current.Append(c);
                    }
                }
            }

            if (current.Length > 0)
            {
                result.Add(current.ToString());
            }

            return result;
        }
        public class EnumType
        {
            public EnumType()
            {
                Values = new List<EnumValueType>();
            }
            public string EnumName { get; set; }
            public string Description { get; set; }
            public List<EnumValueType> Values { get; set; }
        }
        public class EnumValueType
        {
            public string EnumValue { get; set; }
            public string JsonEnumValue { get; set; }
            public int EnumIndex { get; set; }
        }
    }
}
