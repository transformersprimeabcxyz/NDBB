using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace NDBB
{
    public class NativeManager
    {
        // returns path of natives.json in current directory, throws exception on error
        public static String LocalNatives
        {
            get
            {
                String currentDirectory = Directory.GetCurrentDirectory();
                String nativesPath = Path.Combine(currentDirectory, "natives.json");
                if (File.Exists(nativesPath))
                    return nativesPath;
                throw new FileNotFoundException("No local natives.json found");
            }
        }

        // loads a natives.json from given path and returns data
        public static List<NativeNamespace> LoadFromFile(String path)
        {
            List<NativeNamespace> natives = new List<NativeNamespace>();

            String json = File.ReadAllText(path);
            JObject namespaces = JObject.Parse(json);

            // Iterate namespaces
            foreach (KeyValuePair<String, JToken> _namespace in namespaces)
            {
                // Make a new namespace
                NativeNamespace ns = new NativeNamespace()
                {
                    Name = _namespace.Key,
                    Functions = new List<NativeFunction>()
                };

                // Iterate namespace functions
                foreach (KeyValuePair<String, JToken> _function in (JObject)_namespace.Value)
                {
                    // Make a new native function
                    NativeFunction function = new NativeFunction()
                    {
                        Namespace = (String)_namespace.Key,
                        Hash = (String)_function.Key,
                        Name = (String)_function.Value["name"],
                        Result = (String)_function.Value["results"],
                        JHash = (String)_function.Value["jhash"],
                        Params = new List<FunctionParameter>()
                    };
                    // Add function parameters
                    JArray parameters = (JArray)_function.Value["params"];
                    // Add parameters
                    foreach (JObject _parameter in parameters)
                    {
                        FunctionParameter parameter = new FunctionParameter()
                        {
                            Name = _parameter.Value<String>("name"),
                            Type = _parameter.Value<String>("type")
                        };
                        function.Params.Add(parameter);
                    }

                    ns.Functions.Add(function);
                }

                natives.Add(ns);
            }

            return natives;
        }

        // checks for native.json file in current dir
        public static bool LocalNativesExist
        {
            get
            {
                if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "natives.json")))
                    return true;
                return false;
            }
        }

        // exports the natives to given path
        public static void ExportJSON(List<NativeNamespace> natives, String path)
        {
            JObject json = new JObject(
                from ns in natives select new JProperty(ns.Name,
                    new JObject(
                        from func in ns.Functions select new JProperty(func.Hash,
                            new JObject(
                                new JProperty("name", func.Name),
                                new JProperty("params",
                                    new JArray(
                                        from parameters in func.Params select new JObject(
                                            new JProperty("type", parameters.Type),
                                            new JProperty("name", parameters.Name)))),
                                new JProperty("results", func.Result),
                                new JProperty("jhash", func.JHash))))));

            File.WriteAllText(path, json.ToString());
        }

        // exports the natives to given path
        public static void ExportHeader(List<NativeNamespace> natives, String path)
        {
            String h = "#pragma once\n\n" +
                        "#include \"types.h\"\n" +
                        "#include \"nativeCaller.h\"\n\n";

            foreach (var _namespace in natives)
            {
                h += "namespace " + _namespace.Name + "\n{\n";
                foreach (var _function in _namespace.Functions)
                {
                    h += "\tstatic " + _function.Result + " ";

                    String name = "_" + _function.Hash;
                    if (_function.Name.Length > 0)
                        name = _function.Name;
                    h += name + "(";

                    String parameterNames = String.Empty;
                    foreach (var _parameter in _function.Params)
                    {
                        h += _parameter.Type + " " + _parameter.Name + ", ";
                        parameterNames += _parameter.Name + ", ";
                    }
                    h = h.Remove(h.Length - 2);
                    if (parameterNames.Length >= 3)
                        parameterNames = parameterNames.Remove(parameterNames.Length - 2);

                    h += ") { ";
                    if (_function.Result != "void")
                        h += "return ";

                    h += "invoke<" + _function.Result + ">(" + _function.Hash + ", ";
                    h += parameterNames + "); } // " + _function.Hash + " " + _function.JHash + "\n";
                }
                h += "}\n\n";
            }

            File.WriteAllText(path, h);
        }

        // registers an event handler for changes in local natives.json
        public static FileSystemWatcher fw;
        public static void OnNativesChange(FileSystemEventHandler handler)
        {
            if (LocalNativesExist)
            {
                fw = new FileSystemWatcher();
                fw.Path = new FileInfo(LocalNatives).DirectoryName;
                fw.NotifyFilter = NotifyFilters.LastWrite;
                fw.Filter = "natives.json";
                fw.Changed += handler;
                fw.EnableRaisingEvents = true;
            }
        }
    }
}
